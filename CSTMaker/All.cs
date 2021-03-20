
        private void CSTtoAlbumCards(string folder)
        {
            string[] masterCSTs = new string[] { "album_cards.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterAlbumCards[] array = AlbumCards(file);
                    foreach (HpMasterAlbumCards masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterAlbumCards[] AlbumCards(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterAlbumCards> list = new List<HpMasterAlbumCards>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterAlbumCards>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoBeginnerMissionCells(string folder)
        {
            string[] masterCSTs = new string[] { "beginner_mission_cells.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterBeginnerMissionCells[] array = BeginnerMissionCells(file);
                    foreach (HpMasterBeginnerMissionCells masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterBeginnerMissionCells[] BeginnerMissionCells(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterBeginnerMissionCells> list = new List<HpMasterBeginnerMissionCells>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterBeginnerMissionCells>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoBeginnerMissionRewardItems(string folder)
        {
            string[] masterCSTs = new string[] { "beginner_mission_reward_items.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterBeginnerMissionRewardItems[] array = BeginnerMissionRewardItems(file);
                    foreach (HpMasterBeginnerMissionRewardItems masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterBeginnerMissionRewardItems[] BeginnerMissionRewardItems(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterBeginnerMissionRewardItems> list = new List<HpMasterBeginnerMissionRewardItems>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterBeginnerMissionRewardItems>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoBeginnerMissionRewardSets(string folder)
        {
            string[] masterCSTs = new string[] { "beginner_mission_reward_sets.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterBeginnerMissionRewardSets[] array = BeginnerMissionRewardSets(file);
                    foreach (HpMasterBeginnerMissionRewardSets masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterBeginnerMissionRewardSets[] BeginnerMissionRewardSets(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterBeginnerMissionRewardSets> list = new List<HpMasterBeginnerMissionRewardSets>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterBeginnerMissionRewardSets>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoBirthdaySuguroku(string folder)
        {
            string[] masterCSTs = new string[] { "birthday_sugorokus.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterBirthdaySuguroku[] array = BirthdaySuguroku(file);
                    foreach (HpMasterBirthdaySuguroku masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterBirthdaySuguroku[] BirthdaySuguroku(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterBirthdaySuguroku> list = new List<HpMasterBirthdaySuguroku>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterBirthdaySuguroku>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoBirthdaySugurokuCell(string folder)
        {
            string[] masterCSTs = new string[] { "birthday_sugoroku_cells.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterBirthdaySugurokuCell[] array = BirthdaySugurokuCell(file);
                    foreach (HpMasterBirthdaySugurokuCell masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterBirthdaySugurokuCell[] BirthdaySugurokuCell(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterBirthdaySugurokuCell> list = new List<HpMasterBirthdaySugurokuCell>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterBirthdaySugurokuCell>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoBirthdaySugurokuCharacterReward(string folder)
        {
            string[] masterCSTs = new string[] { "birthday_sugoroku_character_reward.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterBirthdaySugurokuCharacterReward[] array = BirthdaySugurokuCharacterReward(file);
                    foreach (HpMasterBirthdaySugurokuCharacterReward masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterBirthdaySugurokuCharacterReward[] BirthdaySugurokuCharacterReward(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterBirthdaySugurokuCharacterReward> list = new List<HpMasterBirthdaySugurokuCharacterReward>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterBirthdaySugurokuCharacterReward>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoBirthdaySugurokuFlexibleItem(string folder)
        {
            string[] masterCSTs = new string[] { "birthday_sugoroku_map_flexible_items.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterBirthdaySugurokuFlexibleItem[] array = BirthdaySugurokuFlexibleItem(file);
                    foreach (HpMasterBirthdaySugurokuFlexibleItem masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterBirthdaySugurokuFlexibleItem[] BirthdaySugurokuFlexibleItem(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterBirthdaySugurokuFlexibleItem> list = new List<HpMasterBirthdaySugurokuFlexibleItem>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterBirthdaySugurokuFlexibleItem>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoBirthdaySugurokuMap(string folder)
        {
            string[] masterCSTs = new string[] { "birthday_sugoroku_maps.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterBirthdaySugurokuMap[] array = BirthdaySugurokuMap(file);
                    foreach (HpMasterBirthdaySugurokuMap masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterBirthdaySugurokuMap[] BirthdaySugurokuMap(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterBirthdaySugurokuMap> list = new List<HpMasterBirthdaySugurokuMap>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterBirthdaySugurokuMap>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoBirthdaySugurokuMapIteratingPoint(string folder)
        {
            string[] masterCSTs = new string[] { "birthday_sugoroku_map_iterating_points.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterBirthdaySugurokuMapIteratingPoint[] array = BirthdaySugurokuMapIteratingPoint(file);
                    foreach (HpMasterBirthdaySugurokuMapIteratingPoint masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterBirthdaySugurokuMapIteratingPoint[] BirthdaySugurokuMapIteratingPoint(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterBirthdaySugurokuMapIteratingPoint> list = new List<HpMasterBirthdaySugurokuMapIteratingPoint>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterBirthdaySugurokuMapIteratingPoint>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoBirthdaySugurokuMapIteratingPointReward(string folder)
        {
            string[] masterCSTs = new string[] { "birthday_sugoroku_map_iterating_points_rewards.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterBirthdaySugurokuMapIteratingPointReward[] array = BirthdaySugurokuMapIteratingPointReward(file);
                    foreach (HpMasterBirthdaySugurokuMapIteratingPointReward masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterBirthdaySugurokuMapIteratingPointReward[] BirthdaySugurokuMapIteratingPointReward(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterBirthdaySugurokuMapIteratingPointReward> list = new List<HpMasterBirthdaySugurokuMapIteratingPointReward>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterBirthdaySugurokuMapIteratingPointReward>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoBirthdaySugurokuMapPattern(string folder)
        {
            string[] masterCSTs = new string[] { "birthday_sugoroku_map_patterns.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterBirthdaySugurokuMapPattern[] array = BirthdaySugurokuMapPattern(file);
                    foreach (HpMasterBirthdaySugurokuMapPattern masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterBirthdaySugurokuMapPattern[] BirthdaySugurokuMapPattern(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterBirthdaySugurokuMapPattern> list = new List<HpMasterBirthdaySugurokuMapPattern>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterBirthdaySugurokuMapPattern>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoBirthdaySugurokuMapPatternCell(string folder)
        {
            string[] masterCSTs = new string[] { "birthday_sugoroku_map_pattern_cells.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterBirthdaySugurokuMapPatternCell[] array = BirthdaySugurokuMapPatternCell(file);
                    foreach (HpMasterBirthdaySugurokuMapPatternCell masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterBirthdaySugurokuMapPatternCell[] BirthdaySugurokuMapPatternCell(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterBirthdaySugurokuMapPatternCell> list = new List<HpMasterBirthdaySugurokuMapPatternCell>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterBirthdaySugurokuMapPatternCell>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoBirthdaySugurokuMapPatternCellRoute(string folder)
        {
            string[] masterCSTs = new string[] { "birthday_sugoroku_map_pattern_routes.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterBirthdaySugurokuMapPatternCellRoute[] array = BirthdaySugurokuMapPatternCellRoute(file);
                    foreach (HpMasterBirthdaySugurokuMapPatternCellRoute masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterBirthdaySugurokuMapPatternCellRoute[] BirthdaySugurokuMapPatternCellRoute(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterBirthdaySugurokuMapPatternCellRoute> list = new List<HpMasterBirthdaySugurokuMapPatternCellRoute>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterBirthdaySugurokuMapPatternCellRoute>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoBirthdaySugurokuMapPoint(string folder)
        {
            string[] masterCSTs = new string[] { "birthday_sugoroku_map_ponts.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterBirthdaySugurokuMapPoint[] array = BirthdaySugurokuMapPoint(file);
                    foreach (HpMasterBirthdaySugurokuMapPoint masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterBirthdaySugurokuMapPoint[] BirthdaySugurokuMapPoint(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterBirthdaySugurokuMapPoint> list = new List<HpMasterBirthdaySugurokuMapPoint>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterBirthdaySugurokuMapPoint>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoBirthdaySugurokuMapPointReward(string folder)
        {
            string[] masterCSTs = new string[] { "birthday_sugoroku_map_point_rewards.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterBirthdaySugurokuMapPointReward[] array = BirthdaySugurokuMapPointReward(file);
                    foreach (HpMasterBirthdaySugurokuMapPointReward masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterBirthdaySugurokuMapPointReward[] BirthdaySugurokuMapPointReward(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterBirthdaySugurokuMapPointReward> list = new List<HpMasterBirthdaySugurokuMapPointReward>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterBirthdaySugurokuMapPointReward>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoBirthdaySugurokuMapRewardPattern(string folder)
        {
            string[] masterCSTs = new string[] { "birthday_sugoroku_map_reward_patterns.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterBirthdaySugurokuMapRewardPattern[] array = BirthdaySugurokuMapRewardPattern(file);
                    foreach (HpMasterBirthdaySugurokuMapRewardPattern masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterBirthdaySugurokuMapRewardPattern[] BirthdaySugurokuMapRewardPattern(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterBirthdaySugurokuMapRewardPattern> list = new List<HpMasterBirthdaySugurokuMapRewardPattern>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterBirthdaySugurokuMapRewardPattern>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCard(string folder)
        {
            string[] masterCSTs = new string[] { "cards.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCard[] array = Card(file);
                    foreach (HpMasterCard masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCard[] Card(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCard> list = new List<HpMasterCard>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCard>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCardCategories(string folder)
        {
            string[] masterCSTs = new string[] { "card_categories.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCardCategories[] array = CardCategories(file);
                    foreach (HpMasterCardCategories masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCardCategories[] CardCategories(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCardCategories> list = new List<HpMasterCardCategories>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCardCategories>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCardCharacterLiveCostume(string folder)
        {
            string[] masterCSTs = new string[] { "card_character_live_costumes.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCardCharacterLiveCostume[] array = CardCharacterLiveCostume(file);
                    foreach (HpMasterCardCharacterLiveCostume masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCardCharacterLiveCostume[] CardCharacterLiveCostume(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCardCharacterLiveCostume> list = new List<HpMasterCardCharacterLiveCostume>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCardCharacterLiveCostume>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCardCostume(string folder)
        {
            string[] masterCSTs = new string[] { "card_costumes.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCardCostume[] array = CardCostume(file);
                    foreach (HpMasterCardCostume masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCardCostume[] CardCostume(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCardCostume> list = new List<HpMasterCardCostume>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCardCostume>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCardCostumeTalkCutins(string folder)
        {
            string[] masterCSTs = new string[] { "card_costume_talk_cutins.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCardCostumeTalkCutins[] array = CardCostumeTalkCutins(file);
                    foreach (HpMasterCardCostumeTalkCutins masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCardCostumeTalkCutins[] CardCostumeTalkCutins(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCardCostumeTalkCutins> list = new List<HpMasterCardCostumeTalkCutins>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCardCostumeTalkCutins>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCardLevel(string folder)
        {
            string[] masterCSTs = new string[] { "card_levels.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCardLevel[] array = CardLevel(file);
                    foreach (HpMasterCardLevel masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCardLevel[] CardLevel(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCardLevel> list = new List<HpMasterCardLevel>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCardLevel>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCardLimitBreakingCountRewards(string folder)
        {
            string[] masterCSTs = new string[] { "card_limit_breaking_count_rewards.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCardLimitBreakingCountRewards[] array = CardLimitBreakingCountRewards(file);
                    foreach (HpMasterCardLimitBreakingCountRewards masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCardLimitBreakingCountRewards[] CardLimitBreakingCountRewards(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCardLimitBreakingCountRewards> list = new List<HpMasterCardLimitBreakingCountRewards>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCardLimitBreakingCountRewards>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCardLimitBreakingCounts(string folder)
        {
            string[] masterCSTs = new string[] { "card_limit_breaking_counts.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCardLimitBreakingCounts[] array = CardLimitBreakingCounts(file);
                    foreach (HpMasterCardLimitBreakingCounts masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCardLimitBreakingCounts[] CardLimitBreakingCounts(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCardLimitBreakingCounts> list = new List<HpMasterCardLimitBreakingCounts>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCardLimitBreakingCounts>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCharacter(string folder)
        {
            string[] masterCSTs = new string[] { "characters.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCharacter[] array = Character(file);
                    foreach (HpMasterCharacter masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCharacter[] Character(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCharacter> list = new List<HpMasterCharacter>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCharacter>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCharacterEmote(string folder)
        {
            string[] masterCSTs = new string[] { "character_emotes.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCharacterEmote[] array = CharacterEmote(file);
                    foreach (HpMasterCharacterEmote masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCharacterEmote[] CharacterEmote(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCharacterEmote> list = new List<HpMasterCharacterEmote>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCharacterEmote>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCharacterFriendshipLevels(string folder)
        {
            string[] masterCSTs = new string[] { "character_friendship_levels.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCharacterFriendshipLevels[] array = CharacterFriendshipLevels(file);
                    foreach (HpMasterCharacterFriendshipLevels masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCharacterFriendshipLevels[] CharacterFriendshipLevels(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCharacterFriendshipLevels> list = new List<HpMasterCharacterFriendshipLevels>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCharacterFriendshipLevels>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCharacterFriendshipPerformanceCoefficient(string folder)
        {
            string[] masterCSTs = new string[] { "character_friendship_performance_coefficients.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCharacterFriendshipPerformanceCoefficient[] array = CharacterFriendshipPerformanceCoefficient(file);
                    foreach (HpMasterCharacterFriendshipPerformanceCoefficient masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCharacterFriendshipPerformanceCoefficient[] CharacterFriendshipPerformanceCoefficient(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCharacterFriendshipPerformanceCoefficient> list = new List<HpMasterCharacterFriendshipPerformanceCoefficient>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCharacterFriendshipPerformanceCoefficient>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCharacterFriendships(string folder)
        {
            string[] masterCSTs = new string[] { "character_friendships.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCharacterFriendships[] array = CharacterFriendships(file);
                    foreach (HpMasterCharacterFriendships masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCharacterFriendships[] CharacterFriendships(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCharacterFriendships> list = new List<HpMasterCharacterFriendships>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCharacterFriendships>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCharacterLiveCostume(string folder)
        {
            string[] masterCSTs = new string[] { "character_live_costumes.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCharacterLiveCostume[] array = CharacterLiveCostume(file);
                    foreach (HpMasterCharacterLiveCostume masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCharacterLiveCostume[] CharacterLiveCostume(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCharacterLiveCostume> list = new List<HpMasterCharacterLiveCostume>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCharacterLiveCostume>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCharacterPositions(string folder)
        {
            string[] masterCSTs = new string[] { "character_positions.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCharacterPositions[] array = CharacterPositions(file);
                    foreach (HpMasterCharacterPositions masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCharacterPositions[] CharacterPositions(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCharacterPositions> list = new List<HpMasterCharacterPositions>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCharacterPositions>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCharacterProfiles(string folder)
        {
            string[] masterCSTs = new string[] { "character_profiles.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCharacterProfiles[] array = CharacterProfiles(file);
                    foreach (HpMasterCharacterProfiles masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCharacterProfiles[] CharacterProfiles(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCharacterProfiles> list = new List<HpMasterCharacterProfiles>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCharacterProfiles>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCharacterTrustEvent(string folder)
        {
            string[] masterCSTs = new string[] { "character_trust_events.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCharacterTrustEvent[] array = CharacterTrustEvent(file);
                    foreach (HpMasterCharacterTrustEvent masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCharacterTrustEvent[] CharacterTrustEvent(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCharacterTrustEvent> list = new List<HpMasterCharacterTrustEvent>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCharacterTrustEvent>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCharacterTrustLevel(string folder)
        {
            string[] masterCSTs = new string[] { "character_trust_levels.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCharacterTrustLevel[] array = CharacterTrustLevel(file);
                    foreach (HpMasterCharacterTrustLevel masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCharacterTrustLevel[] CharacterTrustLevel(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCharacterTrustLevel> list = new List<HpMasterCharacterTrustLevel>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCharacterTrustLevel>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCharacterWords(string folder)
        {
            string[] masterCSTs = new string[] { "character_wrods.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCharacterWords[] array = CharacterWords(file);
                    foreach (HpMasterCharacterWords masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCharacterWords[] CharacterWords(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCharacterWords> list = new List<HpMasterCharacterWords>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCharacterWords>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCharacterWorkType(string folder)
        {
            string[] masterCSTs = new string[] { "character_work_types.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCharacterWorkType[] array = CharacterWorkType(file);
                    foreach (HpMasterCharacterWorkType masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCharacterWorkType[] CharacterWorkType(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCharacterWorkType> list = new List<HpMasterCharacterWorkType>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCharacterWorkType>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoConst(string folder)
        {
            string[] masterCSTs = new string[] { "consts.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterConst[] array = Const(file);
                    foreach (HpMasterConst masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterConst[] Const(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterConst> list = new List<HpMasterConst>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterConst>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCycleAutoLiveRouletteDifficulties(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_auto_live_roulette_difficulties.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCycleAutoLiveRouletteDifficulties[] array = CycleAutoLiveRouletteDifficulties(file);
                    foreach (HpMasterCycleAutoLiveRouletteDifficulties masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCycleAutoLiveRouletteDifficulties[] CycleAutoLiveRouletteDifficulties(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCycleAutoLiveRouletteDifficulties> list = new List<HpMasterCycleAutoLiveRouletteDifficulties>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCycleAutoLiveRouletteDifficulties>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCycleAutoLiveRouletteSuccessProbPercents(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_auto_live_roulette_success_prob_percents.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCycleAutoLiveRouletteSuccessProbPercents[] array = CycleAutoLiveRouletteSuccessProbPercents(file);
                    foreach (HpMasterCycleAutoLiveRouletteSuccessProbPercents masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCycleAutoLiveRouletteSuccessProbPercents[] CycleAutoLiveRouletteSuccessProbPercents(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCycleAutoLiveRouletteSuccessProbPercents> list = new List<HpMasterCycleAutoLiveRouletteSuccessProbPercents>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCycleAutoLiveRouletteSuccessProbPercents>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCycleBoosts(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_boosts.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCycleBoosts[] array = CycleBoosts(file);
                    foreach (HpMasterCycleBoosts masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCycleBoosts[] CycleBoosts(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCycleBoosts> list = new List<HpMasterCycleBoosts>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCycleBoosts>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCycleCharacterWords(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_character_words.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCycleCharacterWords[] array = CycleCharacterWords(file);
                    foreach (HpMasterCycleCharacterWords masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCycleCharacterWords[] CycleCharacterWords(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCycleCharacterWords> list = new List<HpMasterCycleCharacterWords>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCycleCharacterWords>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCycleFocusCard(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_focus_cards.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCycleFocusCard[] array = CycleFocusCard(file);
                    foreach (HpMasterCycleFocusCard masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCycleFocusCard[] CycleFocusCard(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCycleFocusCard> list = new List<HpMasterCycleFocusCard>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCycleFocusCard>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCycleFocusCardLevel(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_focus_card_levels.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCycleFocusCardLevel[] array = CycleFocusCardLevel(file);
                    foreach (HpMasterCycleFocusCardLevel masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCycleFocusCardLevel[] CycleFocusCardLevel(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCycleFocusCardLevel> list = new List<HpMasterCycleFocusCardLevel>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCycleFocusCardLevel>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCycleFocusCardWords(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_focus_card_words.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCycleFocusCardWords[] array = CycleFocusCardWords(file);
                    foreach (HpMasterCycleFocusCardWords masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCycleFocusCardWords[] CycleFocusCardWords(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCycleFocusCardWords> list = new List<HpMasterCycleFocusCardWords>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCycleFocusCardWords>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCycleIteratingPoints(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_iterating_points.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCycleIteratingPoints[] array = CycleIteratingPoints(file);
                    foreach (HpMasterCycleIteratingPoints masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCycleIteratingPoints[] CycleIteratingPoints(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCycleIteratingPoints> list = new List<HpMasterCycleIteratingPoints>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCycleIteratingPoints>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCycleIteratingPointsRewards(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_iterating_point_rewards.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCycleIteratingPointsRewards[] array = CycleIteratingPointsRewards(file);
                    foreach (HpMasterCycleIteratingPointsRewards masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCycleIteratingPointsRewards[] CycleIteratingPointsRewards(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCycleIteratingPointsRewards> list = new List<HpMasterCycleIteratingPointsRewards>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCycleIteratingPointsRewards>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCycleLevel(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_levels.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCycleLevel[] array = CycleLevel(file);
                    foreach (HpMasterCycleLevel masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCycleLevel[] CycleLevel(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCycleLevel> list = new List<HpMasterCycleLevel>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCycleLevel>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCyclePartyLiveScoreRank(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_party_live_score_ranks.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCyclePartyLiveScoreRank[] array = CyclePartyLiveScoreRank(file);
                    foreach (HpMasterCyclePartyLiveScoreRank masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCyclePartyLiveScoreRank[] CyclePartyLiveScoreRank(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCyclePartyLiveScoreRank> list = new List<HpMasterCyclePartyLiveScoreRank>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCyclePartyLiveScoreRank>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCyclePerformanceCoefficients(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_performance_coefficients.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCyclePerformanceCoefficients[] array = CyclePerformanceCoefficients(file);
                    foreach (HpMasterCyclePerformanceCoefficients masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCyclePerformanceCoefficients[] CyclePerformanceCoefficients(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCyclePerformanceCoefficients> list = new List<HpMasterCyclePerformanceCoefficients>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCyclePerformanceCoefficients>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCyclePointRewards(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_point_rewards.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCyclePointRewards[] array = CyclePointRewards(file);
                    foreach (HpMasterCyclePointRewards masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCyclePointRewards[] CyclePointRewards(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCyclePointRewards> list = new List<HpMasterCyclePointRewards>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCyclePointRewards>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCyclePoints(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_points.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCyclePoints[] array = CyclePoints(file);
                    foreach (HpMasterCyclePoints masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCyclePoints[] CyclePoints(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCyclePoints> list = new List<HpMasterCyclePoints>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCyclePoints>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCycleQuest(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_quests.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCycleQuest[] array = CycleQuest(file);
                    foreach (HpMasterCycleQuest masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCycleQuest[] CycleQuest(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCycleQuest> list = new List<HpMasterCycleQuest>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCycleQuest>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCycleQuestMotivation(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_quest_motivations.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCycleQuestMotivation[] array = CycleQuestMotivation(file);
                    foreach (HpMasterCycleQuestMotivation masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCycleQuestMotivation[] CycleQuestMotivation(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCycleQuestMotivation> list = new List<HpMasterCycleQuestMotivation>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCycleQuestMotivation>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCycleQuestWork(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_quest_works.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCycleQuestWork[] array = CycleQuestWork(file);
                    foreach (HpMasterCycleQuestWork masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCycleQuestWork[] CycleQuestWork(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCycleQuestWork> list = new List<HpMasterCycleQuestWork>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCycleQuestWork>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCycleRankingRanges(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_ranking_ranges.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCycleRankingRanges[] array = CycleRankingRanges(file);
                    foreach (HpMasterCycleRankingRanges masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCycleRankingRanges[] CycleRankingRanges(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCycleRankingRanges> list = new List<HpMasterCycleRankingRanges>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCycleRankingRanges>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCycleRankingRangesRewards(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_ranking_range_rewards.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCycleRankingRangesRewards[] array = CycleRankingRangesRewards(file);
                    foreach (HpMasterCycleRankingRangesRewards masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCycleRankingRangesRewards[] CycleRankingRangesRewards(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCycleRankingRangesRewards> list = new List<HpMasterCycleRankingRangesRewards>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCycleRankingRangesRewards>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCycleRequiringSongs(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_requiring_songs.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCycleRequiringSongs[] array = CycleRequiringSongs(file);
                    foreach (HpMasterCycleRequiringSongs masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCycleRequiringSongs[] CycleRequiringSongs(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCycleRequiringSongs> list = new List<HpMasterCycleRequiringSongs>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCycleRequiringSongs>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCycleSpecialCardLimitBreaking(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_special_card_limit_breakings.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCycleSpecialCardLimitBreaking[] array = CycleSpecialCardLimitBreaking(file);
                    foreach (HpMasterCycleSpecialCardLimitBreaking masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCycleSpecialCardLimitBreaking[] CycleSpecialCardLimitBreaking(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCycleSpecialCardLimitBreaking> list = new List<HpMasterCycleSpecialCardLimitBreaking>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCycleSpecialCardLimitBreaking>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoCycleSpecialCards(string folder)
        {
            string[] masterCSTs = new string[] { "cycle_special_cards.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterCycleSpecialCards[] array = CycleSpecialCards(file);
                    foreach (HpMasterCycleSpecialCards masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterCycleSpecialCards[] CycleSpecialCards(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterCycleSpecialCards> list = new List<HpMasterCycleSpecialCards>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterCycleSpecialCards>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoDescriptions(string folder)
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
                        urls
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

        }        private void CSTtoDrama(string folder)
        {
            string[] masterCSTs = new string[] { "dramas.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterDrama[] array = Drama(file);
                    foreach (HpMasterDrama masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterDrama[] Drama(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterDrama> list = new List<HpMasterDrama>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterDrama>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoDramaAssets(string folder)
        {
            string[] masterCSTs = new string[] { "drama_assets.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterDramaAssets[] array = DramaAssets(file);
                    foreach (HpMasterDramaAssets masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterDramaAssets[] DramaAssets(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterDramaAssets> list = new List<HpMasterDramaAssets>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterDramaAssets>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoDramaCharacters(string folder)
        {
            string[] masterCSTs = new string[] { "drama_characters.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterDramaCharacters[] array = DramaCharacters(file);
                    foreach (HpMasterDramaCharacters masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterDramaCharacters[] DramaCharacters(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterDramaCharacters> list = new List<HpMasterDramaCharacters>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterDramaCharacters>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoDramaOnStage(string folder)
        {
            string[] masterCSTs = new string[] { "drama_on_stages.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterDramaOnStage[] array = DramaOnStage(file);
                    foreach (HpMasterDramaOnStage masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterDramaOnStage[] DramaOnStage(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterDramaOnStage> list = new List<HpMasterDramaOnStage>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterDramaOnStage>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoDramaOnStageCast(string folder)
        {
            string[] masterCSTs = new string[] { "drama_on_stage_casts.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterDramaOnStageCast[] array = DramaOnStageCast(file);
                    foreach (HpMasterDramaOnStageCast masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterDramaOnStageCast[] DramaOnStageCast(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterDramaOnStageCast> list = new List<HpMasterDramaOnStageCast>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterDramaOnStageCast>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoDramaOnStageCharacters(string folder)
        {
            string[] masterCSTs = new string[] { "drama_on_stage_characters.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterDramaOnStageCharacters[] array = DramaOnStageCharacters(file);
                    foreach (HpMasterDramaOnStageCharacters masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterDramaOnStageCharacters[] DramaOnStageCharacters(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterDramaOnStageCharacters> list = new List<HpMasterDramaOnStageCharacters>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterDramaOnStageCharacters>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoDramaOnStageMotif(string folder)
        {
            string[] masterCSTs = new string[] { "drama_on_stage_motifs.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterDramaOnStageMotif[] array = DramaOnStageMotif(file);
                    foreach (HpMasterDramaOnStageMotif masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterDramaOnStageMotif[] DramaOnStageMotif(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterDramaOnStageMotif> list = new List<HpMasterDramaOnStageMotif>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterDramaOnStageMotif>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoDummy(string folder)
        {
            string[] masterCSTs = new string[] { "dummies.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterDummy[] array = Dummy(file);
                    foreach (HpMasterDummy masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterDummy[] Dummy(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterDummy> list = new List<HpMasterDummy>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterDummy>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoExchangeCategories(string folder)
        {
            string[] masterCSTs = new string[] { "exchange_categories.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterExchangeCategories[] array = ExchangeCategories(file);
                    foreach (HpMasterExchangeCategories masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterExchangeCategories[] ExchangeCategories(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterExchangeCategories> list = new List<HpMasterExchangeCategories>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterExchangeCategories>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoExchangeItems(string folder)
        {
            string[] masterCSTs = new string[] { "exchange_items.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterExchangeItems[] array = ExchangeItems(file);
                    foreach (HpMasterExchangeItems masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterExchangeItems[] ExchangeItems(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterExchangeItems> list = new List<HpMasterExchangeItems>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterExchangeItems>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoExchangeListDisplayItems(string folder)
        {
            string[] masterCSTs = new string[] { "exchange_list_display_items.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterExchangeListDisplayItems[] array = ExchangeListDisplayItems(file);
                    foreach (HpMasterExchangeListDisplayItems masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterExchangeListDisplayItems[] ExchangeListDisplayItems(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterExchangeListDisplayItems> list = new List<HpMasterExchangeListDisplayItems>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterExchangeListDisplayItems>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoExchangeLists(string folder)
        {
            string[] masterCSTs = new string[] { "exchange_lists.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterExchangeLists[] array = ExchangeLists(file);
                    foreach (HpMasterExchangeLists masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterExchangeLists[] ExchangeLists(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterExchangeLists> list = new List<HpMasterExchangeLists>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterExchangeLists>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoItems(string folder)
        {
            string[] masterCSTs = new string[] { "items.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterItems[] array = Items(file);
                    foreach (HpMasterItems masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterItems[] Items(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterItems> list = new List<HpMasterItems>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterItems>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoLevel(string folder)
        {
            string[] masterCSTs = new string[] { "levels.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterLevel[] array = Level(file);
                    foreach (HpMasterLevel masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterLevel[] Level(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterLevel> list = new List<HpMasterLevel>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterLevel>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoLimitBreakingCondition(string folder)
        {
            string[] masterCSTs = new string[] { "limit_breaking_conditions.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterLimitBreakingCondition[] array = LimitBreakingCondition(file);
                    foreach (HpMasterLimitBreakingCondition masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterLimitBreakingCondition[] LimitBreakingCondition(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterLimitBreakingCondition> list = new List<HpMasterLimitBreakingCondition>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterLimitBreakingCondition>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoLive(string folder)
        {
            string[] masterCSTs = new string[] { "lives.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterLive[] array = Live(file);
                    foreach (HpMasterLive masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterLive[] Live(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterLive> list = new List<HpMasterLive>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterLive>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoLiveAccessory(string folder)
        {
            string[] masterCSTs = new string[] { "live_accessories.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterLiveAccessory[] array = LiveAccessory(file);
                    foreach (HpMasterLiveAccessory masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterLiveAccessory[] LiveAccessory(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterLiveAccessory> list = new List<HpMasterLiveAccessory>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterLiveAccessory>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoLiveCharacterAccessory(string folder)
        {
            string[] masterCSTs = new string[] { "live_character_accessories.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterLiveCharacterAccessory[] array = LiveCharacterAccessory(file);
                    foreach (HpMasterLiveCharacterAccessory masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterLiveCharacterAccessory[] LiveCharacterAccessory(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterLiveCharacterAccessory> list = new List<HpMasterLiveCharacterAccessory>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterLiveCharacterAccessory>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoLiveCharacterEx(string folder)
        {
            string[] masterCSTs = new string[] { "live_character_exs.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterLiveCharacterEx[] array = LiveCharacterEx(file);
                    foreach (HpMasterLiveCharacterEx masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterLiveCharacterEx[] LiveCharacterEx(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterLiveCharacterEx> list = new List<HpMasterLiveCharacterEx>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterLiveCharacterEx>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoLiveCharacterFriendship(string folder)
        {
            string[] masterCSTs = new string[] { "live_character_friendships.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterLiveCharacterFriendship[] array = LiveCharacterFriendship(file);
                    foreach (HpMasterLiveCharacterFriendship masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterLiveCharacterFriendship[] LiveCharacterFriendship(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterLiveCharacterFriendship> list = new List<HpMasterLiveCharacterFriendship>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterLiveCharacterFriendship>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoLiveCharacterFriendshipLevel(string folder)
        {
            string[] masterCSTs = new string[] { "live_character_friendship_levels.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterLiveCharacterFriendshipLevel[] array = LiveCharacterFriendshipLevel(file);
                    foreach (HpMasterLiveCharacterFriendshipLevel masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterLiveCharacterFriendshipLevel[] LiveCharacterFriendshipLevel(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterLiveCharacterFriendshipLevel> list = new List<HpMasterLiveCharacterFriendshipLevel>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterLiveCharacterFriendshipLevel>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoLiveCharacterVoice(string folder)
        {
            string[] masterCSTs = new string[] { "live_character_voices.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterLiveCharacterVoice[] array = LiveCharacterVoice(file);
                    foreach (HpMasterLiveCharacterVoice masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterLiveCharacterVoice[] LiveCharacterVoice(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterLiveCharacterVoice> list = new List<HpMasterLiveCharacterVoice>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterLiveCharacterVoice>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoLiveStage(string folder)
        {
            string[] masterCSTs = new string[] { "live_stages.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterLiveStage[] array = LiveStage(file);
                    foreach (HpMasterLiveStage masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterLiveStage[] LiveStage(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterLiveStage> list = new List<HpMasterLiveStage>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterLiveStage>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoLiveStageDeco(string folder)
        {
            string[] masterCSTs = new string[] { "live_stage_decos.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterLiveStageDeco[] array = LiveStageDeco(file);
                    foreach (HpMasterLiveStageDeco masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterLiveStageDeco[] LiveStageDeco(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterLiveStageDeco> list = new List<HpMasterLiveStageDeco>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterLiveStageDeco>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMainArea(string folder)
        {
            string[] masterCSTs = new string[] { "main_areas.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMainArea[] array = MainArea(file);
                    foreach (HpMasterMainArea masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMainArea[] MainArea(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMainArea> list = new List<HpMasterMainArea>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMainArea>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMainChapter(string folder)
        {
            string[] masterCSTs = new string[] { "main_chapters.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMainChapter[] array = MainChapter(file);
                    foreach (HpMasterMainChapter masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMainChapter[] MainChapter(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMainChapter> list = new List<HpMasterMainChapter>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMainChapter>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMainQuest(string folder)
        {
            string[] masterCSTs = new string[] { "main_quests.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMainQuest[] array = MainQuest(file);
                    foreach (HpMasterMainQuest masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMainQuest[] MainQuest(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMainQuest> list = new List<HpMasterMainQuest>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMainQuest>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMainQuestConditionMission(string folder)
        {
            string[] masterCSTs = new string[] { "main_quest_condition_missions.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMainQuestConditionMission[] array = MainQuestConditionMission(file);
                    foreach (HpMasterMainQuestConditionMission masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMainQuestConditionMission[] MainQuestConditionMission(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMainQuestConditionMission> list = new List<HpMasterMainQuestConditionMission>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMainQuestConditionMission>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMainQuestConditionMissionRewardItem(string folder)
        {
            string[] masterCSTs = new string[] { "main_quest_condition_mission_reward_items.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMainQuestConditionMissionRewardItem[] array = MainQuestConditionMissionRewardItem(file);
                    foreach (HpMasterMainQuestConditionMissionRewardItem masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMainQuestConditionMissionRewardItem[] MainQuestConditionMissionRewardItem(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMainQuestConditionMissionRewardItem> list = new List<HpMasterMainQuestConditionMissionRewardItem>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMainQuestConditionMissionRewardItem>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMainQuestMotivation(string folder)
        {
            string[] masterCSTs = new string[] { "main_quest_motivations.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMainQuestMotivation[] array = MainQuestMotivation(file);
                    foreach (HpMasterMainQuestMotivation masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMainQuestMotivation[] MainQuestMotivation(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMainQuestMotivation> list = new List<HpMasterMainQuestMotivation>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMainQuestMotivation>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMainQuestReleaseCondition(string folder)
        {
            string[] masterCSTs = new string[] { "main_quest_release_conditions.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMainQuestReleaseCondition[] array = MainQuestReleaseCondition(file);
                    foreach (HpMasterMainQuestReleaseCondition masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMainQuestReleaseCondition[] MainQuestReleaseCondition(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMainQuestReleaseCondition> list = new List<HpMasterMainQuestReleaseCondition>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMainQuestReleaseCondition>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMainQuestRequiringSong(string folder)
        {
            string[] masterCSTs = new string[] { "main_quest_requiring_songs.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMainQuestRequiringSong[] array = MainQuestRequiringSong(file);
                    foreach (HpMasterMainQuestRequiringSong masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMainQuestRequiringSong[] MainQuestRequiringSong(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMainQuestRequiringSong> list = new List<HpMasterMainQuestRequiringSong>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMainQuestRequiringSong>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMainQuestWork(string folder)
        {
            string[] masterCSTs = new string[] { "main_quest_works.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMainQuestWork[] array = MainQuestWork(file);
                    foreach (HpMasterMainQuestWork masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMainQuestWork[] MainQuestWork(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMainQuestWork> list = new List<HpMasterMainQuestWork>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMainQuestWork>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonAppealItem(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_appeal_items.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonAppealItem[] array = MarathonAppealItem(file);
                    foreach (HpMasterMarathonAppealItem masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonAppealItem[] MarathonAppealItem(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonAppealItem> list = new List<HpMasterMarathonAppealItem>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonAppealItem>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonBoosts(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_boosts.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonBoosts[] array = MarathonBoosts(file);
                    foreach (HpMasterMarathonBoosts masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonBoosts[] MarathonBoosts(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonBoosts> list = new List<HpMasterMarathonBoosts>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonBoosts>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonCharacterWords(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_character_words.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonCharacterWords[] array = MarathonCharacterWords(file);
                    foreach (HpMasterMarathonCharacterWords masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonCharacterWords[] MarathonCharacterWords(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonCharacterWords> list = new List<HpMasterMarathonCharacterWords>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonCharacterWords>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonFocusCard(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_focus_cards.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonFocusCard[] array = MarathonFocusCard(file);
                    foreach (HpMasterMarathonFocusCard masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonFocusCard[] MarathonFocusCard(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonFocusCard> list = new List<HpMasterMarathonFocusCard>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonFocusCard>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonFocusCardLevel(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_focus_card_levels.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonFocusCardLevel[] array = MarathonFocusCardLevel(file);
                    foreach (HpMasterMarathonFocusCardLevel masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonFocusCardLevel[] MarathonFocusCardLevel(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonFocusCardLevel> list = new List<HpMasterMarathonFocusCardLevel>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonFocusCardLevel>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonFocusCardWords(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_focus_card_words.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonFocusCardWords[] array = MarathonFocusCardWords(file);
                    foreach (HpMasterMarathonFocusCardWords masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonFocusCardWords[] MarathonFocusCardWords(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonFocusCardWords> list = new List<HpMasterMarathonFocusCardWords>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonFocusCardWords>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonIteratingPoints(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_iterating_points.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonIteratingPoints[] array = MarathonIteratingPoints(file);
                    foreach (HpMasterMarathonIteratingPoints masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonIteratingPoints[] MarathonIteratingPoints(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonIteratingPoints> list = new List<HpMasterMarathonIteratingPoints>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonIteratingPoints>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonIteratingPointsReward(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_iterating_point_rewards.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonIteratingPointsReward[] array = MarathonIteratingPointsReward(file);
                    foreach (HpMasterMarathonIteratingPointsReward masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonIteratingPointsReward[] MarathonIteratingPointsReward(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonIteratingPointsReward> list = new List<HpMasterMarathonIteratingPointsReward>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonIteratingPointsReward>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonLevel(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_levels.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonLevel[] array = MarathonLevel(file);
                    foreach (HpMasterMarathonLevel masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonLevel[] MarathonLevel(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonLevel> list = new List<HpMasterMarathonLevel>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonLevel>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonPerformanceCoefficeints(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_performance_coefficients.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonPerformanceCoefficeints[] array = MarathonPerformanceCoefficeints(file);
                    foreach (HpMasterMarathonPerformanceCoefficeints masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonPerformanceCoefficeints[] MarathonPerformanceCoefficeints(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonPerformanceCoefficeints> list = new List<HpMasterMarathonPerformanceCoefficeints>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonPerformanceCoefficeints>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonPointRewards(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_point_rewards.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonPointRewards[] array = MarathonPointRewards(file);
                    foreach (HpMasterMarathonPointRewards masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonPointRewards[] MarathonPointRewards(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonPointRewards> list = new List<HpMasterMarathonPointRewards>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonPointRewards>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonPoints(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_points.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonPoints[] array = MarathonPoints(file);
                    foreach (HpMasterMarathonPoints masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonPoints[] MarathonPoints(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonPoints> list = new List<HpMasterMarathonPoints>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonPoints>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonQuest(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_quests.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonQuest[] array = MarathonQuest(file);
                    foreach (HpMasterMarathonQuest masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonQuest[] MarathonQuest(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonQuest> list = new List<HpMasterMarathonQuest>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonQuest>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonQuestMotivation(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_quest_motivations.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonQuestMotivation[] array = MarathonQuestMotivation(file);
                    foreach (HpMasterMarathonQuestMotivation masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonQuestMotivation[] MarathonQuestMotivation(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonQuestMotivation> list = new List<HpMasterMarathonQuestMotivation>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonQuestMotivation>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonQuestWork(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_quest_works.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonQuestWork[] array = MarathonQuestWork(file);
                    foreach (HpMasterMarathonQuestWork masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonQuestWork[] MarathonQuestWork(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonQuestWork> list = new List<HpMasterMarathonQuestWork>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonQuestWork>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonRankingRanges(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_ranking_ranges.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonRankingRanges[] array = MarathonRankingRanges(file);
                    foreach (HpMasterMarathonRankingRanges masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonRankingRanges[] MarathonRankingRanges(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonRankingRanges> list = new List<HpMasterMarathonRankingRanges>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonRankingRanges>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonRankingRangesRewards(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_ranking_range_rewards.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonRankingRangesRewards[] array = MarathonRankingRangesRewards(file);
                    foreach (HpMasterMarathonRankingRangesRewards masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonRankingRangesRewards[] MarathonRankingRangesRewards(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonRankingRangesRewards> list = new List<HpMasterMarathonRankingRangesRewards>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonRankingRangesRewards>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonRequiringSongs(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_requiring_songs.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonRequiringSongs[] array = MarathonRequiringSongs(file);
                    foreach (HpMasterMarathonRequiringSongs masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonRequiringSongs[] MarathonRequiringSongs(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonRequiringSongs> list = new List<HpMasterMarathonRequiringSongs>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonRequiringSongs>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonSpecialCardLimitBreaking(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_special_card_limit_breakings.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonSpecialCardLimitBreaking[] array = MarathonSpecialCardLimitBreaking(file);
                    foreach (HpMasterMarathonSpecialCardLimitBreaking masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonSpecialCardLimitBreaking[] MarathonSpecialCardLimitBreaking(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonSpecialCardLimitBreaking> list = new List<HpMasterMarathonSpecialCardLimitBreaking>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonSpecialCardLimitBreaking>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMarathonSpecialCards(string folder)
        {
            string[] masterCSTs = new string[] { "marathon_special_cards.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMarathonSpecialCards[] array = MarathonSpecialCards(file);
                    foreach (HpMasterMarathonSpecialCards masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMarathonSpecialCards[] MarathonSpecialCards(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMarathonSpecialCards> list = new List<HpMasterMarathonSpecialCards>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMarathonSpecialCards>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMedals(string folder)
        {
            string[] masterCSTs = new string[] { "medals.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMedals[] array = Medals(file);
                    foreach (HpMasterMedals masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMedals[] Medals(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMedals> list = new List<HpMasterMedals>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMedals>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMemorial(string folder)
        {
            string[] masterCSTs = new string[] { "memorials.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMemorial[] array = Memorial(file);
                    foreach (HpMasterMemorial masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMemorial[] Memorial(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMemorial> list = new List<HpMasterMemorial>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMemorial>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMemorialCard(string folder)
        {
            string[] masterCSTs = new string[] { "memorial_cards.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMemorialCard[] array = MemorialCard(file);
                    foreach (HpMasterMemorialCard masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMemorialCard[] MemorialCard(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMemorialCard> list = new List<HpMasterMemorialCard>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMemorialCard>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMemorialCategory(string folder)
        {
            string[] masterCSTs = new string[] { "memorial_categories.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMemorialCategory[] array = MemorialCategory(file);
                    foreach (HpMasterMemorialCategory masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMemorialCategory[] MemorialCategory(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMemorialCategory> list = new List<HpMasterMemorialCategory>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMemorialCategory>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMemorialCustomCard(string folder)
        {
            string[] masterCSTs = new string[] { "memorial_custom_cards.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMemorialCustomCard[] array = MemorialCustomCard(file);
                    foreach (HpMasterMemorialCustomCard masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMemorialCustomCard[] MemorialCustomCard(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMemorialCustomCard> list = new List<HpMasterMemorialCustomCard>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMemorialCustomCard>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMemorialCustomItem(string folder)
        {
            string[] masterCSTs = new string[] { "memorial_custom_items.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMemorialCustomItem[] array = MemorialCustomItem(file);
                    foreach (HpMasterMemorialCustomItem masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMemorialCustomItem[] MemorialCustomItem(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMemorialCustomItem> list = new List<HpMasterMemorialCustomItem>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMemorialCustomItem>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMission(string folder)
        {
            string[] masterCSTs = new string[] { "missions.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMission[] array = Mission(file);
                    foreach (HpMasterMission masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMission[] Mission(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMission> list = new List<HpMasterMission>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMission>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMissionRewardItem(string folder)
        {
            string[] masterCSTs = new string[] { "mission_reward_items.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMissionRewardItem[] array = MissionRewardItem(file);
                    foreach (HpMasterMissionRewardItem masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMissionRewardItem[] MissionRewardItem(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMissionRewardItem> list = new List<HpMasterMissionRewardItem>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMissionRewardItem>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoMyDeskMusic(string folder)
        {
            string[] masterCSTs = new string[] { "my_desk_musics.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterMyDeskMusic[] array = MyDeskMusic(file);
                    foreach (HpMasterMyDeskMusic masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterMyDeskMusic[] MyDeskMusic(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterMyDeskMusic> list = new List<HpMasterMyDeskMusic>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterMyDeskMusic>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoOutwork(string folder)
        {
            string[] masterCSTs = new string[] { "outworks.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterOutwork[] array = Outwork(file);
                    foreach (HpMasterOutwork masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterOutwork[] Outwork(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterOutwork> list = new List<HpMasterOutwork>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterOutwork>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoOutworkReward(string folder)
        {
            string[] masterCSTs = new string[] { "outwork_rewards.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterOutworkReward[] array = OutworkReward(file);
                    foreach (HpMasterOutworkReward masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterOutworkReward[] OutworkReward(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterOutworkReward> list = new List<HpMasterOutworkReward>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterOutworkReward>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoOutworkRewardCell(string folder)
        {
            string[] masterCSTs = new string[] { "outwork_reward_cells.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterOutworkRewardCell[] array = OutworkRewardCell(file);
                    foreach (HpMasterOutworkRewardCell masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterOutworkRewardCell[] OutworkRewardCell(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterOutworkRewardCell> list = new List<HpMasterOutworkRewardCell>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterOutworkRewardCell>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoPerformance(string folder)
        {
            string[] masterCSTs = new string[] { "performances.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterPerformance[] array = Performance(file);
                    foreach (HpMasterPerformance masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterPerformance[] Performance(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterPerformance> list = new List<HpMasterPerformance>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterPerformance>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoPerformanceEffect(string folder)
        {
            string[] masterCSTs = new string[] { "performance_effects.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterPerformanceEffect[] array = PerformanceEffect(file);
                    foreach (HpMasterPerformanceEffect masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterPerformanceEffect[] PerformanceEffect(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterPerformanceEffect> list = new List<HpMasterPerformanceEffect>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterPerformanceEffect>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoPoints(string folder)
        {
            string[] masterCSTs = new string[] { "points.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterPoints[] array = Points(file);
                    foreach (HpMasterPoints masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterPoints[] Points(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterPoints> list = new List<HpMasterPoints>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterPoints>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoSong(string folder)
        {
            string[] masterCSTs = new string[] { "songs.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterSong[] array = Song(file);
                    foreach (HpMasterSong masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterSong[] Song(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterSong> list = new List<HpMasterSong>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterSong>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoSongCharacterMotion(string folder)
        {
            string[] masterCSTs = new string[] { "song_character_motions.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterSongCharacterMotion[] array = SongCharacterMotion(file);
                    foreach (HpMasterSongCharacterMotion masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterSongCharacterMotion[] SongCharacterMotion(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterSongCharacterMotion> list = new List<HpMasterSongCharacterMotion>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterSongCharacterMotion>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoSongCharacters(string folder)
        {
            string[] masterCSTs = new string[] { "song_characters.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterSongCharacters[] array = SongCharacters(file);
                    foreach (HpMasterSongCharacters masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterSongCharacters[] SongCharacters(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterSongCharacters> list = new List<HpMasterSongCharacters>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterSongCharacters>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoSongCharacterSpecialMotion(string folder)
        {
            string[] masterCSTs = new string[] { "song_character_special_motions.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterSongCharacterSpecialMotion[] array = SongCharacterSpecialMotion(file);
                    foreach (HpMasterSongCharacterSpecialMotion masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterSongCharacterSpecialMotion[] SongCharacterSpecialMotion(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterSongCharacterSpecialMotion> list = new List<HpMasterSongCharacterSpecialMotion>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterSongCharacterSpecialMotion>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoSongDifficulty(string folder)
        {
            string[] masterCSTs = new string[] { "song_difficulties.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterSongDifficulty[] array = SongDifficulty(file);
                    foreach (HpMasterSongDifficulty masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterSongDifficulty[] SongDifficulty(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterSongDifficulty> list = new List<HpMasterSongDifficulty>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterSongDifficulty>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoSongTiming(string folder)
        {
            string[] masterCSTs = new string[] { "song_timings.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterSongTiming[] array = SongTiming(file);
                    foreach (HpMasterSongTiming masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterSongTiming[] SongTiming(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterSongTiming> list = new List<HpMasterSongTiming>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterSongTiming>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoSpeaks(string folder)
        {
            string[] masterCSTs = new string[] { "speaks.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterSpeaks[] array = Speaks(file);
                    foreach (HpMasterSpeaks masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterSpeaks[] Speaks(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterSpeaks> list = new List<HpMasterSpeaks>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterSpeaks>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoSpLessonCellCond(string folder)
        {
            string[] masterCSTs = new string[] { "sp_lesson_cell_conditions.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterSpLessonCellCond[] array = SpLessonCellCond(file);
                    foreach (HpMasterSpLessonCellCond masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterSpLessonCellCond[] SpLessonCellCond(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterSpLessonCellCond> list = new List<HpMasterSpLessonCellCond>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterSpLessonCellCond>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoSpLessonCellCondSetRelations(string folder)
        {
            string[] masterCSTs = new string[] { "sp_lesson_cell_condition_sets.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterSpLessonCellCondSetRelations[] array = SpLessonCellCondSetRelations(file);
                    foreach (HpMasterSpLessonCellCondSetRelations masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterSpLessonCellCondSetRelations[] SpLessonCellCondSetRelations(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterSpLessonCellCondSetRelations> list = new List<HpMasterSpLessonCellCondSetRelations>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterSpLessonCellCondSetRelations>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoSpLessonCellRewards(string folder)
        {
            string[] masterCSTs = new string[] { "sp_lesson_cell_rewards.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterSpLessonCellRewards[] array = SpLessonCellRewards(file);
                    foreach (HpMasterSpLessonCellRewards masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterSpLessonCellRewards[] SpLessonCellRewards(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterSpLessonCellRewards> list = new List<HpMasterSpLessonCellRewards>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterSpLessonCellRewards>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoSpLessonCells(string folder)
        {
            string[] masterCSTs = new string[] { "sp_lesson_cells.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterSpLessonCells[] array = SpLessonCells(file);
                    foreach (HpMasterSpLessonCells masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterSpLessonCells[] SpLessonCells(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterSpLessonCells> list = new List<HpMasterSpLessonCells>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterSpLessonCells>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoSpLessonCharaMessages(string folder)
        {
            string[] masterCSTs = new string[] { "sp_lesson_character_messages.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterSpLessonCharaMessages[] array = SpLessonCharaMessages(file);
                    foreach (HpMasterSpLessonCharaMessages masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterSpLessonCharaMessages[] SpLessonCharaMessages(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterSpLessonCharaMessages> list = new List<HpMasterSpLessonCharaMessages>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterSpLessonCharaMessages>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoSpLessonChibiCharaMessages(string folder)
        {
            string[] masterCSTs = new string[] { "sp_lesson_chibi_character_messages.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterSpLessonChibiCharaMessages[] array = SpLessonChibiCharaMessages(file);
                    foreach (HpMasterSpLessonChibiCharaMessages masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterSpLessonChibiCharaMessages[] SpLessonChibiCharaMessages(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterSpLessonChibiCharaMessages> list = new List<HpMasterSpLessonChibiCharaMessages>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterSpLessonChibiCharaMessages>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoSpLessonMenuCond(string folder)
        {
            string[] masterCSTs = new string[] { "sp_lesson_menu_conditions.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterSpLessonMenuCond[] array = SpLessonMenuCond(file);
                    foreach (HpMasterSpLessonMenuCond masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterSpLessonMenuCond[] SpLessonMenuCond(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterSpLessonMenuCond> list = new List<HpMasterSpLessonMenuCond>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterSpLessonMenuCond>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoSpLessonMenuCondSetRelations(string folder)
        {
            string[] masterCSTs = new string[] { "sp_lesson_menu_condition_set_relations.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterSpLessonMenuCondSetRelations[] array = SpLessonMenuCondSetRelations(file);
                    foreach (HpMasterSpLessonMenuCondSetRelations masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterSpLessonMenuCondSetRelations[] SpLessonMenuCondSetRelations(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterSpLessonMenuCondSetRelations> list = new List<HpMasterSpLessonMenuCondSetRelations>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterSpLessonMenuCondSetRelations>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoSpLessonMenus(string folder)
        {
            string[] masterCSTs = new string[] { "sp_lesson_menus.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterSpLessonMenus[] array = SpLessonMenus(file);
                    foreach (HpMasterSpLessonMenus masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterSpLessonMenus[] SpLessonMenus(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterSpLessonMenus> list = new List<HpMasterSpLessonMenus>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterSpLessonMenus>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoTalks(string folder)
        {
            string[] masterCSTs = new string[] { "talks.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterTalks[] array = Talks(file);
                    foreach (HpMasterTalks masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterTalks[] Talks(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterTalks> list = new List<HpMasterTalks>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterTalks>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoTips(string folder)
        {
            string[] masterCSTs = new string[] { "tips.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterTips[] array = Tips(file);
                    foreach (HpMasterTips masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterTips[] Tips(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterTips> list = new List<HpMasterTips>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterTips>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoTutorialAssets(string folder)
        {
            string[] masterCSTs = new string[] { "tutorial_assets.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterTutorialAssets[] array = TutorialAssets(file);
                    foreach (HpMasterTutorialAssets masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterTutorialAssets[] TutorialAssets(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterTutorialAssets> list = new List<HpMasterTutorialAssets>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterTutorialAssets>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoTutorialMessages(string folder)
        {
            string[] masterCSTs = new string[] { "tutorial_messages.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterTutorialMessages[] array = TutorialMessages(file);
                    foreach (HpMasterTutorialMessages masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterTutorialMessages[] TutorialMessages(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterTutorialMessages> list = new List<HpMasterTutorialMessages>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterTutorialMessages>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoUnit(string folder)
        {
            string[] masterCSTs = new string[] { "units.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterUnit[] array = Unit(file);
                    foreach (HpMasterUnit masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterUnit[] Unit(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterUnit> list = new List<HpMasterUnit>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterUnit>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoViewModeEmote(string folder)
        {
            string[] masterCSTs = new string[] { "view_mode_emotes.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterViewModeEmote[] array = ViewModeEmote(file);
                    foreach (HpMasterViewModeEmote masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterViewModeEmote[] ViewModeEmote(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterViewModeEmote> list = new List<HpMasterViewModeEmote>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterViewModeEmote>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoViewModeEmoteSet(string folder)
        {
            string[] masterCSTs = new string[] { "view_mode_emote_sets.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterViewModeEmoteSet[] array = ViewModeEmoteSet(file);
                    foreach (HpMasterViewModeEmoteSet masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterViewModeEmoteSet[] ViewModeEmoteSet(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterViewModeEmoteSet> list = new List<HpMasterViewModeEmoteSet>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterViewModeEmoteSet>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoVoiceBookItem(string folder)
        {
            string[] masterCSTs = new string[] { "voice_book_items.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterVoiceBookItem[] array = VoiceBookItem(file);
                    foreach (HpMasterVoiceBookItem masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterVoiceBookItem[] VoiceBookItem(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterVoiceBookItem> list = new List<HpMasterVoiceBookItem>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterVoiceBookItem>(current.Value, false));
            }
            return list.ToArray();

        }        private void CSTtoWords(string folder)
        {
            string[] masterCSTs = new string[] { "words.cst" };
            foreach (string masterCST in masterCSTs)
            {
                try
                {
                    string urls = "";
                    string file = Path.Combine(folder, masterCST);
                    HpMasterWords[] array = Words(file);
                    foreach (HpMasterWords masterMission in array)
                    {
                        urls
                    }
                    File.WriteAllText(file.Replace(".cst", "-decrypted.txt"), urls);
                }
                catch { }
            }
        }
	
	        private HpMasterWords[] Words(string file)
        {
            byte[] CstIn = File.ReadAllBytes(file);
            byte[] CstDecrypted = HpCrypt.DecryptBytes(CstIn, p1);
            Dictionary<long, byte[]> dictionary = HpMasterCluster.Decode_ToMasterBins(CstDecrypted, false);
            List<HpMasterWords> list = new List<HpMasterWords>();
            foreach (KeyValuePair<long, byte[]> current in dictionary)
            {
                list.Add(HpMasterBin.Decode<HpMasterWords>(current.Value, false));
            }
            return list.ToArray();

        }