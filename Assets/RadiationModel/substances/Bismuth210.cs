using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth210 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth210";
        public override double halfLife { get; } = 433036.8d;
        public override double atomicWeight { get; } = 209.98412d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium210()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 1.32e-06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium206()), new(1.0d, new AlphaParticle(6058402.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00195d },
            { 3000.0d, 0.00195029d },
            { 6000.0d, 0.00195046d },
            { 9000.0d, 0.00195049d },
            { 12000.0d, 0.00195039d },
            { 15000.0d, 0.00195016d },
            { 18000.0d, 0.00194981d },
            { 21000.0d, 0.00194932d },
            { 24000.0d, 0.00194871d },
            { 27000.0d, 0.00194797d },
            { 30000.0d, 0.0019471d },
            { 33000.0d, 0.00194611d },
            { 36000.0d, 0.00194499d },
            { 39000.0d, 0.00194375d },
            { 42000.0d, 0.00194239d },
            { 45000.0d, 0.00194091d },
            { 48000.0d, 0.00193932d },
            { 51000.0d, 0.00193761d },
            { 54000.0d, 0.00193578d },
            { 57000.0d, 0.00193384d },
            { 60000.0d, 0.00193179d },
            { 63000.0d, 0.00192962d },
            { 66000.0d, 0.00192735d },
            { 69000.0d, 0.00192497d },
            { 72000.0d, 0.00192249d },
            { 75000.0d, 0.0019199d },
            { 78000.0d, 0.00191721d },
            { 81000.0d, 0.00191441d },
            { 84000.0d, 0.00191152d },
            { 87000.0d, 0.00190852d },
            { 90000.0d, 0.00190543d },
            { 93000.0d, 0.00190224d },
            { 96000.0d, 0.00189895d },
            { 99000.0d, 0.00189557d },
            { 102000.0d, 0.00189209d },
            { 105000.0d, 0.00188852d },
            { 108000.0d, 0.00188486d },
            { 111000.0d, 0.0018811d },
            { 114000.0d, 0.00187726d },
            { 117000.0d, 0.00187333d },
            { 120000.0d, 0.00186931d },
            { 123000.0d, 0.00186521d },
            { 126000.0d, 0.00186101d },
            { 129000.0d, 0.00185674d },
            { 132000.0d, 0.00185238d },
            { 135000.0d, 0.00184793d },
            { 138000.0d, 0.00184341d },
            { 141000.0d, 0.0018388d },
            { 144000.0d, 0.00183412d },
            { 147000.0d, 0.00182935d },
            { 150000.0d, 0.00182451d },
            { 153000.0d, 0.00181959d },
            { 156000.0d, 0.00181459d },
            { 159000.0d, 0.00180952d },
            { 162000.0d, 0.00180437d },
            { 165000.0d, 0.00179915d },
            { 168000.0d, 0.00179385d },
            { 171000.0d, 0.00178849d },
            { 174000.0d, 0.00178305d },
            { 177000.0d, 0.00177755d },
            { 180000.0d, 0.00177197d },
            { 183000.0d, 0.00176633d },
            { 186000.0d, 0.00176062d },
            { 189000.0d, 0.00175485d },
            { 192000.0d, 0.00174901d },
            { 195000.0d, 0.0017431d },
            { 198000.0d, 0.00173713d },
            { 201000.0d, 0.0017311d },
            { 204000.0d, 0.00172501d },
            { 207000.0d, 0.00171886d },
            { 210000.0d, 0.00171264d },
            { 213000.0d, 0.00170637d },
            { 216000.0d, 0.00170004d },
            { 219000.0d, 0.00169365d },
            { 222000.0d, 0.00168721d },
            { 225000.0d, 0.00168071d },
            { 228000.0d, 0.00167416d },
            { 231000.0d, 0.00166755d },
            { 234000.0d, 0.0016609d },
            { 237000.0d, 0.00165418d },
            { 240000.0d, 0.00164742d },
            { 243000.0d, 0.00164061d },
            { 246000.0d, 0.00163375d },
            { 249000.0d, 0.00162685d },
            { 252000.0d, 0.00161989d },
            { 255000.0d, 0.00161289d },
            { 258000.0d, 0.00160584d },
            { 261000.0d, 0.00159875d },
            { 264000.0d, 0.00159162d },
            { 267000.0d, 0.00158444d },
            { 270000.0d, 0.00157722d },
            { 273000.0d, 0.00156996d },
            { 276000.0d, 0.00156266d },
            { 279000.0d, 0.00155532d },
            { 282000.0d, 0.00154795d },
            { 285000.0d, 0.00154053d },
            { 288000.0d, 0.00153308d },
            { 291000.0d, 0.00152559d },
            { 294000.0d, 0.00151807d },
            { 297000.0d, 0.00151051d },
            { 300000.0d, 0.00150292d },
            { 303000.0d, 0.0014953d },
            { 306000.0d, 0.00148765d },
            { 309000.0d, 0.00147996d },
            { 312000.0d, 0.00147225d },
            { 315000.0d, 0.00146451d },
            { 318000.0d, 0.00145674d },
            { 321000.0d, 0.00144894d },
            { 324000.0d, 0.00144111d },
            { 327000.0d, 0.00143326d },
            { 330000.0d, 0.00142539d },
            { 333000.0d, 0.00141749d },
            { 336000.0d, 0.00140957d },
            { 339000.0d, 0.00140162d },
            { 342000.0d, 0.00139366d },
            { 345000.0d, 0.00138567d },
            { 348000.0d, 0.00137766d },
            { 351000.0d, 0.00136963d },
            { 354000.0d, 0.00136159d },
            { 357000.0d, 0.00135353d },
            { 360000.0d, 0.00134545d },
            { 363000.0d, 0.00133735d },
            { 366000.0d, 0.00132924d },
            { 369000.0d, 0.00132112d },
            { 372000.0d, 0.00131298d },
            { 375000.0d, 0.00130483d },
            { 378000.0d, 0.00129666d },
            { 381000.0d, 0.00128849d },
            { 384000.0d, 0.0012803d },
            { 387000.0d, 0.0012721d },
            { 390000.0d, 0.0012639d },
            { 393000.0d, 0.00125568d },
            { 396000.0d, 0.00124746d },
            { 399000.0d, 0.00123923d },
            { 402000.0d, 0.00123099d },
            { 405000.0d, 0.00122275d },
            { 408000.0d, 0.0012145d },
            { 411000.0d, 0.00120625d },
            { 414000.0d, 0.001198d },
            { 417000.0d, 0.00118974d },
            { 420000.0d, 0.00118148d },
            { 423000.0d, 0.00117322d },
            { 426000.0d, 0.00116495d },
            { 429000.0d, 0.00115669d },
            { 432000.0d, 0.00114843d },
            { 435000.0d, 0.00114017d },
            { 438000.0d, 0.00113191d },
            { 441000.0d, 0.00112365d },
            { 444000.0d, 0.0011154d },
            { 447000.0d, 0.00110715d },
            { 450000.0d, 0.0010989d },
            { 453000.0d, 0.00109066d },
            { 456000.0d, 0.00108242d },
            { 459000.0d, 0.00107419d },
            { 462000.0d, 0.00106597d },
            { 465000.0d, 0.00105775d },
            { 468000.0d, 0.00104955d },
            { 471000.0d, 0.00104135d },
            { 474000.0d, 0.00103316d },
            { 477000.0d, 0.00102498d },
            { 480000.0d, 0.00101681d },
            { 483000.0d, 0.00100865d },
            { 486000.0d, 0.0010005d },
            { 489000.0d, 0.000992362d },
            { 492000.0d, 0.000984239d },
            { 495000.0d, 0.000976129d },
            { 498000.0d, 0.000968032d },
            { 501000.0d, 0.000959949d },
            { 504000.0d, 0.000951881d },
            { 507000.0d, 0.000943829d },
            { 510000.0d, 0.000935792d },
            { 513000.0d, 0.000927771d },
            { 516000.0d, 0.000919768d },
            { 519000.0d, 0.000911781d },
            { 522000.0d, 0.000903812d },
            { 525000.0d, 0.000895861d },
            { 528000.0d, 0.00088793d },
            { 531000.0d, 0.000880017d },
            { 534000.0d, 0.000872124d },
            { 537000.0d, 0.000864251d },
            { 540000.0d, 0.000856399d },
            { 543000.0d, 0.000848568d },
            { 546000.0d, 0.000840758d },
            { 549000.0d, 0.000832971d },
            { 552000.0d, 0.000825205d },
            { 555000.0d, 0.000817463d },
            { 558000.0d, 0.000809744d },
            { 561000.0d, 0.000802049d },
            { 564000.0d, 0.000794378d },
            { 567000.0d, 0.000786731d },
            { 570000.0d, 0.000779109d },
            { 573000.0d, 0.000771513d },
            { 576000.0d, 0.000763942d },
            { 579000.0d, 0.000756398d },
            { 582000.0d, 0.00074888d },
            { 585000.0d, 0.000741389d },
            { 588000.0d, 0.000733925d },
            { 591000.0d, 0.000726489d },
            { 594000.0d, 0.00071908d },
            { 597000.0d, 0.000711701d },
            { 600000.0d, 0.000704349d },
            { 603000.0d, 0.000697027d },
            { 606000.0d, 0.000689735d },
            { 609000.0d, 0.000682472d },
            { 612000.0d, 0.000675239d },
            { 615000.0d, 0.000668037d },
            { 618000.0d, 0.000660865d },
            { 621000.0d, 0.000653724d },
            { 624000.0d, 0.000646615d },
            { 627000.0d, 0.000639537d },
            { 630000.0d, 0.000632491d },
            { 633000.0d, 0.000625477d },
            { 636000.0d, 0.000618496d },
            { 639000.0d, 0.000611548d },
            { 642000.0d, 0.000604633d },
            { 645000.0d, 0.000597751d },
            { 648000.0d, 0.000590902d },
            { 651000.0d, 0.000584088d },
            { 654000.0d, 0.000577308d },
            { 657000.0d, 0.000570562d },
            { 660000.0d, 0.000563851d },
            { 663000.0d, 0.000557174d },
            { 666000.0d, 0.000550533d },
            { 669000.0d, 0.000543927d },
            { 672000.0d, 0.000537356d },
            { 675000.0d, 0.000530822d },
            { 678000.0d, 0.000524323d },
            { 681000.0d, 0.000517861d },
            { 684000.0d, 0.000511435d },
            { 687000.0d, 0.000505045d },
            { 690000.0d, 0.000498693d },
            { 693000.0d, 0.000492377d },
            { 696000.0d, 0.000486099d },
            { 699000.0d, 0.000479858d },
            { 702000.0d, 0.000473654d },
            { 705000.0d, 0.000467489d },
            { 708000.0d, 0.000461361d },
            { 711000.0d, 0.000455271d },
            { 714000.0d, 0.00044922d },
            { 717000.0d, 0.000443206d },
            { 720000.0d, 0.000437232d },
            { 723000.0d, 0.000431296d },
            { 726000.0d, 0.000425399d },
            { 729000.0d, 0.000419541d },
            { 732000.0d, 0.000413722d },
            { 735000.0d, 0.000407942d },
            { 738000.0d, 0.000402202d },
            { 741000.0d, 0.000396501d },
            { 744000.0d, 0.00039084d },
            { 747000.0d, 0.000385218d },
            { 750000.0d, 0.000379636d },
            { 753000.0d, 0.000374094d },
            { 756000.0d, 0.000368593d },
            { 759000.0d, 0.000363131d },
            { 762000.0d, 0.000357709d },
            { 765000.0d, 0.000352328d },
            { 768000.0d, 0.000346988d },
            { 771000.0d, 0.000341687d },
            { 774000.0d, 0.000336428d },
            { 777000.0d, 0.000331209d },
            { 780000.0d, 0.00032603d },
            { 783000.0d, 0.000320893d },
            { 786000.0d, 0.000315796d },
            { 789000.0d, 0.00031074d },
            { 792000.0d, 0.000305725d },
            { 795000.0d, 0.000300751d },
            { 798000.0d, 0.000295819d },
            { 801000.0d, 0.000290927d },
            { 804000.0d, 0.000286076d },
            { 807000.0d, 0.000281267d },
            { 810000.0d, 0.000276499d },
            { 813000.0d, 0.000271772d },
            { 816000.0d, 0.000267087d },
            { 819000.0d, 0.000262443d },
            { 822000.0d, 0.00025784d },
            { 825000.0d, 0.000253279d },
            { 828000.0d, 0.000248759d },
            { 831000.0d, 0.00024428d },
            { 834000.0d, 0.000239843d },
            { 837000.0d, 0.000235448d },
            { 840000.0d, 0.000231094d },
            { 843000.0d, 0.000226781d },
            { 846000.0d, 0.00022251d },
            { 849000.0d, 0.00021828d },
            { 852000.0d, 0.000214092d },
            { 855000.0d, 0.000209945d },
            { 858000.0d, 0.00020584d },
            { 861000.0d, 0.000201776d },
            { 864000.0d, 0.000197754d },
            { 867000.0d, 0.000193773d },
            { 870000.0d, 0.000189834d },
            { 873000.0d, 0.000185936d },
            { 876000.0d, 0.00018208d },
            { 879000.0d, 0.000178265d },
            { 882000.0d, 0.000174491d },
            { 885000.0d, 0.000170759d },
            { 888000.0d, 0.000167068d },
            { 891000.0d, 0.000163418d },
            { 894000.0d, 0.00015981d },
            { 897000.0d, 0.000156242d },
            { 900000.0d, 0.000152717d },
            { 903000.0d, 0.000149232d },
            { 906000.0d, 0.000145788d },
            { 909000.0d, 0.000142386d },
            { 912000.0d, 0.000139025d },
            { 915000.0d, 0.000135704d },
            { 918000.0d, 0.000132425d },
            { 921000.0d, 0.000129187d },
            { 924000.0d, 0.00012599d },
            { 927000.0d, 0.000122834d },
            { 930000.0d, 0.000119718d },
            { 933000.0d, 0.000116644d },
            { 936000.0d, 0.00011361d },
            { 939000.0d, 0.000110617d },
            { 942000.0d, 0.000107664d },
            { 945000.0d, 0.000104753d },
            { 948000.0d, 0.000101882d },
            { 951000.0d, 0.0000990513d },
            { 954000.0d, 0.0000962614d },
            { 957000.0d, 0.000093512d },
            { 960000.0d, 0.000090803d },
            { 963000.0d, 0.0000881345d },
            { 966000.0d, 0.0000855063d },
            { 969000.0d, 0.0000829185d },
            { 972000.0d, 0.0000803709d },
            { 975000.0d, 0.0000778636d },
            { 978000.0d, 0.0000753964d },
            { 981000.0d, 0.0000729694d },
            { 984000.0d, 0.0000705825d },
            { 987000.0d, 0.0000682357d },
            { 990000.0d, 0.0000659289d },
            { 993000.0d, 0.0000636621d },
            { 996000.0d, 0.0000614353d },
            { 999000.0d, 0.0000592483d },
            { 1002000.0d, 0.0000571012d },
            { 1005000.0d, 0.000054994d },
            { 1008000.0d, 0.0000529265d },
            { 1011000.0d, 0.0000508988d },
            { 1014000.0d, 0.0000489108d },
            { 1017000.0d, 0.0000469626d },
            { 1020000.0d, 0.0000450539d },
            { 1023000.0d, 0.000043185d },
            { 1026000.0d, 0.0000413556d },
            { 1029000.0d, 0.0000395658d },
            { 1032000.0d, 0.0000378155d },
            { 1035000.0d, 0.0000361048d },
            { 1038000.0d, 0.0000344336d },
            { 1041000.0d, 0.0000328019d },
            { 1044000.0d, 0.0000312096d },
            { 1047000.0d, 0.0000296568d },
            { 1050000.0d, 0.0000281435d },
            { 1053000.0d, 0.0000266696d },
            { 1056000.0d, 0.0000252351d },
            { 1059000.0d, 0.00002384d },
            { 1062000.0d, 0.0000224843d },
            { 1065000.0d, 0.000021168d },
            { 1068000.0d, 0.0000198912d },
            { 1071000.0d, 0.0000186537d },
            { 1074000.0d, 0.0000174557d },
            { 1077000.0d, 0.0000162971d },
            { 1080000.0d, 0.0000151779d },
            { 1083000.0d, 0.0000140982d },
            { 1086000.0d, 0.0000130579d },
            { 1089000.0d, 0.0000120572d },
            { 1092000.0d, 0.0000110959d },
            { 1095000.0d, 0.0000101742d },
            { 1098000.0d, 0.00000929208d },
            { 1101000.0d, 0.00000844955d },
            { 1104000.0d, 0.00000764667d },
            { 1107000.0d, 0.00000688347d },
            { 1110000.0d, 0.00000616001d },
            { 1113000.0d, 0.00000547632d },
            { 1116000.0d, 0.00000483247d },
            { 1119000.0d, 0.00000422851d },
            { 1122000.0d, 0.00000366449d },
            { 1125000.0d, 0.0000031405d },
            { 1128000.0d, 0.00000265658d },
            { 1131000.0d, 0.00000221282d },
            { 1134000.0d, 0.0000018093d },
            { 1137000.0d, 0.00000144609d },
            { 1140000.0d, 0.00000112329d },
            { 1143000.0d, 0.000000840987d },
            { 1146000.0d, 0.000000599274d },
            { 1149000.0d, 0.000000398254d },
            { 1152000.0d, 0.000000238034d },
            { 1155000.0d, 0.000000118724d },
            { 1158000.0d, 0.0000000404404d },
            { 1161000.0d, 0.0000000033047d },
            { 1162200.0d, 0d },

        }; 
    }
}
    