using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShellcodeStringTool
{
	public class TEA
	{

		// Ctor
		public TEA()
		{
		}

		public string Encrypt(string Data, string Key, bool bUnicode)
		{
			uint[] formattedKey = FormatKey(Key);

			int n = Data.Length % 8;
			for (int i = 0; i < 8 - n; i++)
			{
				Data += '\0';
			}

			byte[] dataBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(Data);
			string cipher = string.Empty;

			uint[] tempData;
			if (bUnicode)
			{
				tempData = new uint[dataBytes.Length * 2];
				for (int i = 0; i < dataBytes.Length * 2; i += 2)
				{
					tempData[i] = dataBytes[i / 2];
					tempData[i + 1] = '\0';
				}
			}
			else
			{
				tempData = new uint[dataBytes.Length];
				for (int i = 0; i < dataBytes.Length; i++)
				{
					tempData[i] = dataBytes[i];
				}
			}

			code(tempData, formattedKey);

			for (int i = 0; i < tempData.Length; i++)
			{
				cipher += ("0x" + tempData[i].ToString("X"));
				if (i != tempData.Length - 1)
				{
					cipher += ", ";
				}
			}

			return cipher;
		}

		// error now! should be modify
		public string Decrypt(string Data, string Key)
		{
			uint[] formattedKey = FormatKey(Key);

			int x = 0;
			uint[] tempData = new uint[2];
			byte[] dataBytes = new byte[Data.Length / 8 * 2];
			for (int i = 0; i < Data.Length; i += 8)
			{
				tempData[0] = Util.ConvertStringToUInt(Data.Substring(i, 4));
				tempData[1] = Util.ConvertStringToUInt(Data.Substring(i + 4, 4));
				decode(tempData, formattedKey);
				dataBytes[x++] = (byte)tempData[0];
				dataBytes[x++] = (byte)tempData[1];
			}

			string decipheredString = System.Text.ASCIIEncoding.ASCII.GetString(dataBytes, 0, dataBytes.Length);
			if (decipheredString[decipheredString.Length - 1] == '\0') // Strip the null char if it was added.
				decipheredString = decipheredString.Substring(0, decipheredString.Length - 1);
			return decipheredString;
		}

		public uint[] FormatKey(string Key)
		{
			/*if (Key.Length == 0)
				throw new ArgumentException("Key must be between 1 and 16 characters in length");
			*/
			Key = Key.PadRight(16, ' ').Substring(0, 16); // Ensure that the key is 16 chars in length.
			uint[] formattedKey = new uint[4];

			// Get the key into the correct format for TEA usage.
			int j = 0;
			for (int i = 0; i < Key.Length; i += 4)
				formattedKey[j++] = Util.ConvertStringToUInt(Key.Substring(i, 4));

			return formattedKey;
		}

		#region Tea Algorithm
		public void code(uint[] v, uint[] k)
		{
			int round = v.Length / 8;
			for (int i = 0; i < round; i++)
			{
				uint y = (v[i * 8 + 0] << 24) | (v[i * 8 + 1] << 16) | (v[i * 8 + 2] << 8) | v[i * 8 + 3];
				uint z = (v[i * 8 + 4] << 24) | (v[i * 8 + 5] << 16) | (v[i * 8 + 6] << 8) | v[i * 8 + 7];

				uint sum = 0;
				uint delta = 0x9e3779b9;
				uint n = 32;

				while (n-- > 0)
				{
					sum += delta;
					y += (z << 4) + k[0] ^ (z + sum) ^ (z >> 5) + k[1];
					z += (y << 4) + k[2] ^ (y + sum) ^ (y >> 5) + k[3];
				}

				v[i * 8 + 0] = ((y >> 24) & 0xFF);
				v[i * 8 + 1] = ((y >> 16) & 0xFF);
				v[i * 8 + 2] = ((y >> 8) & 0xFF);
				v[i * 8 + 3] = ((y >> 0) & 0xFF);
				v[i * 8 + 4] = ((z >> 24) & 0xFF);
				v[i * 8 + 5] = ((z >> 16) & 0xFF);
				v[i * 8 + 6] = ((z >> 8) & 0xFF);
				v[i * 8 + 7] = ((z >> 0) & 0xFF);
			}
		}

		public void decode(uint[] v, uint[] k)
		{
			uint n = 32;
			uint sum;
			uint y = v[0];
			uint z = v[1];
			uint delta = 0x9e3779b9;

			sum = delta << 5;

			while (n-- > 0)
			{
				z -= (y << 4) + k[2] ^ y + sum ^ (y >> 5) + k[3];
				y -= (z << 4) + k[0] ^ z + sum ^ (z >> 5) + k[1];
				sum -= delta;
			}

			v[0] = y;
			v[1] = z;
		}
		#endregion
	}
}
