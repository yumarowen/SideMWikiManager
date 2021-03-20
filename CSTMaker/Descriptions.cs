        private void CSTtoDescriptions(string folder)
        {
            string[] masterCSTs = new string[] { "descriptions.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterDescriptions[] array = Descriptions(file);
                    foreach (HpMasterDescriptions masterMission in array)
                    {
                        urls += "motifId=" + masterMission.motifId
                            + "\r\n";
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterDescriptions[] Descriptions(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterDescriptions> list = new List<HpMasterDescriptions>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterDescriptions>(current.Value, false));
            }
            return list.ToArray();

        }
	// put this on env. start
	CSTtoDescriptions(Directory.GetCurrentDirectory() + "/masters/");