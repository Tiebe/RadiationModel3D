using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Germanium82 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium82";
        public override double halfLife { get; } = 4.0d;
        public override double atomicWeight { get; } = 81.92977d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Arsenic82()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00774d, new GammaParticle(92600.0, 0.01339)), new(0.027864d, new GammaParticle(249100.0, 0.00498)), new(0.00387d, new GammaParticle(329300.0, 0.00377)), new(0.0020898d, new GammaParticle(420400.0, 0.00295)), new(0.0067338d, new GammaParticle(426600.0, 0.00291)), new(0.00387d, new GammaParticle(447400.0, 0.00277)), new(0.009675d, new GammaParticle(516500.0, 0.0024)), new(0.0017028d, new GammaParticle(526300.0, 0.00236)), new(0.001548d, new GammaParticle(553100.0, 0.00224)), new(0.008514d, new GammaParticle(575300.0, 0.00216)), new(0.06192d, new GammaParticle(843400.0, 0.00147)), new(0.010835999999999998d, new GammaParticle(951800.0, 0.0013)), new(0.0012384d, new GammaParticle(1063900.0, 0.00117)), new(0.774d, new GammaParticle(1092000.0, 0.00114)), new(0.00387d, new GammaParticle(1199100.0, 0.00103)), new(0.004644d, new GammaParticle(1201100.0, 0.00103)), new(0.0026316d, new GammaParticle(1311300.0, 0.00095)), new(0.0023994d, new GammaParticle(1462400.0, 0.00085)), new(0.0006966d, new GammaParticle(1600100.0, 0.00077)), new(0.0009288d, new GammaParticle(2196600.0, 0.00056)), new(1.584347814e-05d, new GammaParticle(1320.0, 0.93927)), new(0.0001288912296974457d, new GammaParticle(10509.0, 0.11798)), new(0.0002501285264844667d, new GammaParticle(10544.0, 0.11759)), new(5.7192613044986985e-05d, new GammaParticle(11773.0, 0.10531)), new(5.935449381808749e-05d, new GammaParticle(11791.0, 0.10515)), new(2.161880773100508e-06d, new GammaParticle(11861.0, 0.10453)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0000721576d },
            { 7000.0d, 0.0000735161d },
            { 14000.0d, 0.0000750029d },
            { 21000.0d, 0.0000766179d },
            { 28000.0d, 0.0000783626d },
            { 35000.0d, 0.0000802274d },
            { 42000.0d, 0.0000821756d },
            { 49000.0d, 0.0000841908d },
            { 56000.0d, 0.0000862576d },
            { 63000.0d, 0.0000883591d },
            { 70000.0d, 0.0000904934d },
            { 77000.0d, 0.0000926528d },
            { 84000.0d, 0.0000948308d },
            { 91000.0d, 0.0000970272d },
            { 98000.0d, 0.0000992379d },
            { 105000.0d, 0.000101461d },
            { 115000.0d, 0.000104655d },
            { 125000.0d, 0.000107868d },
            { 135000.0d, 0.000111098d },
            { 145000.0d, 0.00011434d },
            { 155000.0d, 0.000117594d },
            { 165000.0d, 0.000120859d },
            { 175000.0d, 0.000124132d },
            { 185000.0d, 0.000127412d },
            { 195000.0d, 0.000130699d },
            { 205000.0d, 0.000133992d },
            { 215000.0d, 0.00013729d },
            { 225000.0d, 0.000140592d },
            { 235000.0d, 0.000143896d },
            { 245000.0d, 0.000147202d },
            { 255000.0d, 0.00015051d },
            { 265000.0d, 0.000153818d },
            { 275000.0d, 0.000157127d },
            { 285000.0d, 0.000160434d },
            { 295000.0d, 0.00016374d },
            { 305000.0d, 0.000167044d },
            { 315000.0d, 0.000170345d },
            { 325000.0d, 0.000173642d },
            { 335000.0d, 0.000176935d },
            { 345000.0d, 0.000180223d },
            { 355000.0d, 0.000183506d },
            { 365000.0d, 0.000186782d },
            { 375000.0d, 0.000190051d },
            { 385000.0d, 0.000193313d },
            { 395000.0d, 0.000196568d },
            { 405000.0d, 0.000199812d },
            { 415000.0d, 0.000203048d },
            { 425000.0d, 0.000206274d },
            { 435000.0d, 0.000209489d },
            { 445000.0d, 0.000212693d },
            { 455000.0d, 0.000215884d },
            { 465000.0d, 0.000219064d },
            { 475000.0d, 0.000222231d },
            { 485000.0d, 0.000225384d },
            { 495000.0d, 0.000228523d },
            { 505000.0d, 0.000231648d },
            { 515000.0d, 0.000234757d },
            { 525000.0d, 0.00023785d },
            { 535000.0d, 0.000240927d },
            { 545000.0d, 0.000243987d },
            { 555000.0d, 0.00024703d },
            { 565000.0d, 0.000250055d },
            { 575000.0d, 0.000253062d },
            { 585000.0d, 0.00025605d },
            { 595000.0d, 0.000259018d },
            { 605000.0d, 0.000261966d },
            { 615000.0d, 0.000264894d },
            { 625000.0d, 0.000267801d },
            { 635000.0d, 0.000270686d },
            { 645000.0d, 0.000273549d },
            { 655000.0d, 0.000276391d },
            { 665000.0d, 0.00027921d },
            { 675000.0d, 0.000282005d },
            { 685000.0d, 0.000284777d },
            { 695000.0d, 0.000287524d },
            { 705000.0d, 0.000290247d },
            { 715000.0d, 0.000292944d },
            { 725000.0d, 0.000295617d },
            { 735000.0d, 0.000298264d },
            { 745000.0d, 0.000300884d },
            { 755000.0d, 0.000303478d },
            { 765000.0d, 0.000306045d },
            { 775000.0d, 0.000308584d },
            { 785000.0d, 0.000311095d },
            { 795000.0d, 0.000313579d },
            { 805000.0d, 0.000316033d },
            { 815000.0d, 0.000318459d },
            { 825000.0d, 0.000320855d },
            { 835000.0d, 0.000323222d },
            { 845000.0d, 0.000325559d },
            { 855000.0d, 0.000327865d },
            { 865000.0d, 0.000330141d },
            { 875000.0d, 0.000332386d },
            { 885000.0d, 0.0003346d },
            { 895000.0d, 0.000336782d },
            { 905000.0d, 0.000338932d },
            { 915000.0d, 0.00034105d },
            { 925000.0d, 0.000343135d },
            { 935000.0d, 0.000345188d },
            { 945000.0d, 0.000347207d },
            { 955000.0d, 0.000349193d },
            { 965000.0d, 0.000351146d },
            { 975000.0d, 0.000353065d },
            { 985000.0d, 0.00035495d },
            { 995000.0d, 0.0003568d },
            { 1005000.0d, 0.000358615d },
            { 1018000.0d, 0.000360923d },
            { 1031000.0d, 0.000363172d },
            { 1044000.0d, 0.000365361d },
            { 1057000.0d, 0.000367489d },
            { 1070000.0d, 0.000369556d },
            { 1083000.0d, 0.000371563d },
            { 1096000.0d, 0.000373507d },
            { 1109000.0d, 0.00037539d },
            { 1122000.0d, 0.00037721d },
            { 1135000.0d, 0.000378967d },
            { 1148000.0d, 0.000380661d },
            { 1161000.0d, 0.000382291d },
            { 1174000.0d, 0.000383859d },
            { 1187000.0d, 0.000385361d },
            { 1200000.0d, 0.000386799d },
            { 1213000.0d, 0.000388173d },
            { 1226000.0d, 0.000389482d },
            { 1239000.0d, 0.000390726d },
            { 1252000.0d, 0.000391904d },
            { 1265000.0d, 0.000393017d },
            { 1278000.0d, 0.000394064d },
            { 1291000.0d, 0.000395046d },
            { 1304000.0d, 0.000395962d },
            { 1317000.0d, 0.000396811d },
            { 1330000.0d, 0.000397595d },
            { 1343000.0d, 0.000398312d },
            { 1356000.0d, 0.000398962d },
            { 1369000.0d, 0.000399547d },
            { 1382000.0d, 0.000400065d },
            { 1395000.0d, 0.000400517d },
            { 1408000.0d, 0.000400902d },
            { 1421000.0d, 0.00040122d },
            { 1434000.0d, 0.000401472d },
            { 1447000.0d, 0.000401659d },
            { 1460000.0d, 0.000401779d },
            { 1473000.0d, 0.000401832d },
            { 1486000.0d, 0.00040182d },
            { 1499000.0d, 0.000401741d },
            { 1512000.0d, 0.000401598d },
            { 1525000.0d, 0.000401388d },
            { 1538000.0d, 0.000401113d },
            { 1551000.0d, 0.000400772d },
            { 1564000.0d, 0.000400365d },
            { 1577000.0d, 0.000399895d },
            { 1590000.0d, 0.00039936d },
            { 1603000.0d, 0.00039876d },
            { 1616000.0d, 0.000398096d },
            { 1629000.0d, 0.000397368d },
            { 1642000.0d, 0.000396577d },
            { 1655000.0d, 0.000395722d },
            { 1668000.0d, 0.000394804d },
            { 1681000.0d, 0.000393825d },
            { 1694000.0d, 0.000392782d },
            { 1707000.0d, 0.000391678d },
            { 1720000.0d, 0.000390512d },
            { 1733000.0d, 0.000389285d },
            { 1746000.0d, 0.000387998d },
            { 1759000.0d, 0.000386651d },
            { 1772000.0d, 0.000385243d },
            { 1785000.0d, 0.000383777d },
            { 1798000.0d, 0.000382252d },
            { 1811000.0d, 0.000380669d },
            { 1824000.0d, 0.000379028d },
            { 1837000.0d, 0.00037733d },
            { 1850000.0d, 0.000375576d },
            { 1863000.0d, 0.000373765d },
            { 1876000.0d, 0.000371898d },
            { 1889000.0d, 0.000369977d },
            { 1902000.0d, 0.000368002d },
            { 1915000.0d, 0.000365973d },
            { 1928000.0d, 0.000363891d },
            { 1941000.0d, 0.000361757d },
            { 1954000.0d, 0.000359572d },
            { 1967000.0d, 0.000357335d },
            { 1980000.0d, 0.000355049d },
            { 1993000.0d, 0.000352713d },
            { 2006000.0d, 0.000350328d },
            { 2019000.0d, 0.000347895d },
            { 2032000.0d, 0.000345415d },
            { 2045000.0d, 0.000342889d },
            { 2058000.0d, 0.000340317d },
            { 2071000.0d, 0.000337701d },
            { 2084000.0d, 0.00033504d },
            { 2097000.0d, 0.000332337d },
            { 2110000.0d, 0.000329591d },
            { 2123000.0d, 0.000326804d },
            { 2136000.0d, 0.000323977d },
            { 2149000.0d, 0.00032111d },
            { 2162000.0d, 0.000318204d },
            { 2175000.0d, 0.000315261d },
            { 2188000.0d, 0.000312282d },
            { 2201000.0d, 0.000309266d },
            { 2214000.0d, 0.000306216d },
            { 2227000.0d, 0.000303133d },
            { 2240000.0d, 0.000300017d },
            { 2253000.0d, 0.000296867d },
            { 2266000.0d, 0.000293687d },
            { 2279000.0d, 0.000290475d },
            { 2292000.0d, 0.000287233d },
            { 2305000.0d, 0.000283961d },
            { 2318000.0d, 0.000280661d },
            { 2331000.0d, 0.000277333d },
            { 2344000.0d, 0.000273979d },
            { 2357000.0d, 0.0002706d },
            { 2370000.0d, 0.000267197d },
            { 2383000.0d, 0.00026377d },
            { 2396000.0d, 0.000260322d },
            { 2409000.0d, 0.000256852d },
            { 2422000.0d, 0.000253359d },
            { 2435000.0d, 0.000249846d },
            { 2448000.0d, 0.000246312d },
            { 2461000.0d, 0.00024276d },
            { 2474000.0d, 0.000239189d },
            { 2487000.0d, 0.000235603d },
            { 2500000.0d, 0.000232d },
            { 2513000.0d, 0.000228385d },
            { 2526000.0d, 0.000224755d },
            { 2539000.0d, 0.000221114d },
            { 2552000.0d, 0.000217462d },
            { 2565000.0d, 0.000213801d },
            { 2578000.0d, 0.000210132d },
            { 2591000.0d, 0.000206457d },
            { 2604000.0d, 0.000202776d },
            { 2617000.0d, 0.00019909d },
            { 2630000.0d, 0.000195402d },
            { 2643000.0d, 0.000191712d },
            { 2656000.0d, 0.00018802d },
            { 2669000.0d, 0.000184323d },
            { 2682000.0d, 0.000180624d },
            { 2695000.0d, 0.000176922d },
            { 2708000.0d, 0.00017322d },
            { 2721000.0d, 0.000169518d },
            { 2734000.0d, 0.000165818d },
            { 2747000.0d, 0.000162122d },
            { 2760000.0d, 0.00015843d },
            { 2773000.0d, 0.000154744d },
            { 2786000.0d, 0.000151065d },
            { 2799000.0d, 0.000147395d },
            { 2812000.0d, 0.000143735d },
            { 2825000.0d, 0.000140086d },
            { 2838000.0d, 0.00013645d },
            { 2851000.0d, 0.000132828d },
            { 2864000.0d, 0.000129222d },
            { 2877000.0d, 0.000125633d },
            { 2890000.0d, 0.000122062d },
            { 2903000.0d, 0.000118511d },
            { 2916000.0d, 0.000114981d },
            { 2929000.0d, 0.000111474d },
            { 2942000.0d, 0.000107992d },
            { 2955000.0d, 0.000104534d },
            { 2968000.0d, 0.000101104d },
            { 2981000.0d, 0.0000977035d },
            { 2994000.0d, 0.0000943329d },
            { 3007000.0d, 0.0000909942d },
            { 3020000.0d, 0.0000876889d },
            { 3033000.0d, 0.0000844185d },
            { 3046000.0d, 0.0000811846d },
            { 3059000.0d, 0.0000779888d },
            { 3072000.0d, 0.0000748329d },
            { 3085000.0d, 0.0000717183d },
            { 3098000.0d, 0.0000686467d },
            { 3111000.0d, 0.0000656196d },
            { 3124000.0d, 0.0000626388d },
            { 3137000.0d, 0.0000597059d },
            { 3150000.0d, 0.0000568226d },
            { 3163000.0d, 0.0000539905d },
            { 3176000.0d, 0.0000512113d },
            { 3189000.0d, 0.0000484867d },
            { 3202000.0d, 0.0000458185d },
            { 3215000.0d, 0.0000432082d },
            { 3228000.0d, 0.0000406579d },
            { 3241000.0d, 0.000038169d },
            { 3254000.0d, 0.0000357433d },
            { 3267000.0d, 0.0000333827d },
            { 3280000.0d, 0.0000310889d },
            { 3293000.0d, 0.0000288637d },
            { 3306000.0d, 0.0000267088d },
            { 3319000.0d, 0.0000246261d },
            { 3332000.0d, 0.0000226171d },
            { 3345000.0d, 0.0000206837d },
            { 3358000.0d, 0.0000188275d },
            { 3371000.0d, 0.0000170506d },
            { 3384000.0d, 0.0000153545d },
            { 3397000.0d, 0.0000137412d },
            { 3410000.0d, 0.0000122126d },
            { 3423000.0d, 0.0000107705d },
            { 3436000.0d, 0.00000941681d },
            { 3449000.0d, 0.00000815332d },
            { 3462000.0d, 0.00000698191d },
            { 3475000.0d, 0.00000590445d },
            { 3488000.0d, 0.00000492285d },
            { 3501000.0d, 0.00000403899d },
            { 3514000.0d, 0.0000032547d },
            { 3527000.0d, 0.00000257183d },
            { 3540000.0d, 0.0000019922d },
            { 3553000.0d, 0.00000151761d },
            { 3566000.0d, 0.00000114993d },
            { 3579000.0d, 0.00000089074d },
            { 3592000.0d, 0.000000741439d },
            { 3605000.0d, 0.000000676664d },
            { 3618000.0d, 0.000000619325d },
            { 3631000.0d, 0.000000564391d },
            { 3644000.0d, 0.000000511918d },
            { 3657000.0d, 0.00000046196d },
            { 3670000.0d, 0.000000414573d },
            { 3683000.0d, 0.000000369812d },
            { 3696000.0d, 0.000000327733d },
            { 3709000.0d, 0.000000288394d },
            { 3722000.0d, 0.000000251849d },
            { 3735000.0d, 0.000000218155d },
            { 3748000.0d, 0.000000187368d },
            { 3761000.0d, 0.000000159544d },
            { 3774000.0d, 0.00000013474d },
            { 3787000.0d, 0.000000113012d },
            { 3800000.0d, 0.0000000944142d },
            { 3813000.0d, 0.0000000790014d },
            { 3826000.0d, 0.000000066825d },
            { 3839000.0d, 0.0000000579315d },
            { 3852000.0d, 0.0000000519046d },
            { 3865000.0d, 0.0000000464786d },
            { 3878000.0d, 0.0000000413414d },
            { 3891000.0d, 0.0000000365035d },
            { 3904000.0d, 0.0000000319754d },
            { 3917000.0d, 0.0000000277676d },
            { 3930000.0d, 0.0000000238909d },
            { 3943000.0d, 0.0000000203564d },
            { 3956000.0d, 0.0000000171751d },
            { 3969000.0d, 0.000000014358d },
            { 3982000.0d, 0.0000000119163d },
            { 3995000.0d, 0.00000000986136d },
            { 4008000.0d, 0.00000000820366d },
            { 4021000.0d, 0.00000000692851d },
            { 4034000.0d, 0.00000000580604d },
            { 4047000.0d, 0.00000000477772d },
            { 4060000.0d, 0.00000000384511d },
            { 4073000.0d, 0.00000000300979d },
            { 4086000.0d, 0.00000000227334d },
            { 4099000.0d, 0.00000000163731d },
            { 4112000.0d, 0.00000000110323d },
            { 4125000.0d, 0.000000000672622d },
            { 4138000.0d, 0.00000000034693d },
            { 4151000.0d, 0.000000000127523d },
            { 4164000.0d, 0.0000000000155464d },
            { 4171000.0d, 0d },

        }; 
    }
}
    