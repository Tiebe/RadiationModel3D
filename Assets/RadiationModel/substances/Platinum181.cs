using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum181 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum181";
        public override double halfLife { get; } = 52.0d;
        public override double atomicWeight { get; } = 180.96309d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium181()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0008d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium177()), new(1.0d, new AlphaParticle(6172002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 7000.0d, 0.00000000245025d },
            { 14000.0d, 0.0000000299654d },
            { 21000.0d, 0.0000000965401d },
            { 28000.0d, 0.000000216041d },
            { 35000.0d, 0.000000404286d },
            { 42000.0d, 0.000000664263d },
            { 49000.0d, 0.000000999271d },
            { 56000.0d, 0.0000014077d },
            { 63000.0d, 0.0000018874d },
            { 70000.0d, 0.00000243427d },
            { 77000.0d, 0.00000304453d },
            { 84000.0d, 0.00000371315d },
            { 91000.0d, 0.0000044359d },
            { 98000.0d, 0.00000520758d },
            { 105000.0d, 0.00000602474d },
            { 115000.0d, 0.0000072613d },
            { 125000.0d, 0.00000857031d },
            { 135000.0d, 0.00000994165d },
            { 145000.0d, 0.0000113661d },
            { 155000.0d, 0.0000128354d },
            { 165000.0d, 0.0000143424d },
            { 175000.0d, 0.0000158813d },
            { 185000.0d, 0.0000174462d },
            { 195000.0d, 0.0000190322d },
            { 205000.0d, 0.0000206347d },
            { 215000.0d, 0.0000222501d },
            { 225000.0d, 0.0000238749d },
            { 235000.0d, 0.0000255059d },
            { 245000.0d, 0.0000271405d },
            { 255000.0d, 0.0000287762d },
            { 265000.0d, 0.0000304108d },
            { 275000.0d, 0.0000320424d },
            { 285000.0d, 0.0000336693d },
            { 295000.0d, 0.0000352898d },
            { 305000.0d, 0.0000369026d },
            { 315000.0d, 0.0000385063d },
            { 325000.0d, 0.0000400999d },
            { 335000.0d, 0.0000416823d },
            { 345000.0d, 0.0000432525d },
            { 355000.0d, 0.0000448097d },
            { 365000.0d, 0.0000463532d },
            { 375000.0d, 0.0000478822d },
            { 385000.0d, 0.0000493961d },
            { 395000.0d, 0.0000508943d },
            { 405000.0d, 0.0000523763d },
            { 415000.0d, 0.0000538415d },
            { 425000.0d, 0.0000552896d },
            { 435000.0d, 0.0000567202d },
            { 445000.0d, 0.0000581328d },
            { 455000.0d, 0.0000595272d },
            { 465000.0d, 0.0000609032d },
            { 475000.0d, 0.0000622602d },
            { 485000.0d, 0.0000635981d },
            { 495000.0d, 0.0000649167d },
            { 505000.0d, 0.0000662158d },
            { 515000.0d, 0.0000674951d },
            { 525000.0d, 0.0000687546d },
            { 535000.0d, 0.0000699939d },
            { 545000.0d, 0.0000712132d },
            { 555000.0d, 0.0000724121d },
            { 565000.0d, 0.0000735903d },
            { 575000.0d, 0.0000747481d },
            { 585000.0d, 0.0000758853d },
            { 595000.0d, 0.0000770017d },
            { 605000.0d, 0.0000780972d },
            { 615000.0d, 0.0000791719d },
            { 625000.0d, 0.0000802256d },
            { 635000.0d, 0.0000812583d },
            { 645000.0d, 0.0000822701d },
            { 655000.0d, 0.0000832606d },
            { 665000.0d, 0.0000842302d },
            { 675000.0d, 0.0000851787d },
            { 685000.0d, 0.000086106d },
            { 695000.0d, 0.000087012d },
            { 705000.0d, 0.000087897d },
            { 715000.0d, 0.000088761d },
            { 725000.0d, 0.0000896038d },
            { 735000.0d, 0.0000904253d },
            { 745000.0d, 0.0000912261d },
            { 755000.0d, 0.0000920055d },
            { 765000.0d, 0.0000927641d },
            { 775000.0d, 0.0000935015d },
            { 785000.0d, 0.000094218d },
            { 795000.0d, 0.0000949138d },
            { 805000.0d, 0.0000955884d },
            { 815000.0d, 0.0000962423d },
            { 825000.0d, 0.0000968756d },
            { 835000.0d, 0.000097488d },
            { 845000.0d, 0.0000980797d },
            { 855000.0d, 0.0000986509d },
            { 865000.0d, 0.0000992017d },
            { 875000.0d, 0.0000997319d },
            { 885000.0d, 0.000100242d },
            { 895000.0d, 0.000100731d },
            { 905000.0d, 0.000101201d },
            { 915000.0d, 0.00010165d },
            { 925000.0d, 0.000102079d },
            { 935000.0d, 0.000102488d },
            { 945000.0d, 0.000102878d },
            { 955000.0d, 0.000103248d },
            { 965000.0d, 0.000103598d },
            { 975000.0d, 0.000103928d },
            { 985000.0d, 0.000104239d },
            { 995000.0d, 0.000104531d },
            { 1005000.0d, 0.000104803d },
            { 1018000.0d, 0.000105129d },
            { 1031000.0d, 0.000105422d },
            { 1044000.0d, 0.000105684d },
            { 1057000.0d, 0.000105914d },
            { 1070000.0d, 0.000106113d },
            { 1083000.0d, 0.000106281d },
            { 1096000.0d, 0.000106419d },
            { 1109000.0d, 0.000106526d },
            { 1122000.0d, 0.000106603d },
            { 1135000.0d, 0.00010665d },
            { 1148000.0d, 0.000106668d },
            { 1161000.0d, 0.000106657d },
            { 1174000.0d, 0.000106617d },
            { 1187000.0d, 0.000106549d },
            { 1200000.0d, 0.000106452d },
            { 1213000.0d, 0.000106328d },
            { 1226000.0d, 0.000106177d },
            { 1239000.0d, 0.000105998d },
            { 1252000.0d, 0.000105793d },
            { 1265000.0d, 0.000105562d },
            { 1278000.0d, 0.000105305d },
            { 1291000.0d, 0.000105022d },
            { 1304000.0d, 0.000104715d },
            { 1317000.0d, 0.000104383d },
            { 1330000.0d, 0.000104026d },
            { 1343000.0d, 0.000103646d },
            { 1356000.0d, 0.000103242d },
            { 1369000.0d, 0.000102816d },
            { 1382000.0d, 0.000102367d },
            { 1395000.0d, 0.000101896d },
            { 1408000.0d, 0.000101403d },
            { 1421000.0d, 0.000100889d },
            { 1434000.0d, 0.000100354d },
            { 1447000.0d, 0.0000997993d },
            { 1460000.0d, 0.0000992248d },
            { 1473000.0d, 0.0000986308d },
            { 1486000.0d, 0.0000980182d },
            { 1499000.0d, 0.0000973871d },
            { 1512000.0d, 0.0000967384d },
            { 1525000.0d, 0.0000960723d },
            { 1538000.0d, 0.0000953893d },
            { 1551000.0d, 0.0000946901d },
            { 1564000.0d, 0.000093975d },
            { 1577000.0d, 0.000093245d },
            { 1590000.0d, 0.0000924999d },
            { 1603000.0d, 0.0000917409d },
            { 1616000.0d, 0.0000909681d },
            { 1629000.0d, 0.0000901823d },
            { 1642000.0d, 0.0000893839d },
            { 1655000.0d, 0.0000885735d },
            { 1668000.0d, 0.0000877519d },
            { 1681000.0d, 0.0000869193d },
            { 1694000.0d, 0.0000860765d },
            { 1707000.0d, 0.000085224d },
            { 1720000.0d, 0.0000843624d },
            { 1733000.0d, 0.0000834923d },
            { 1746000.0d, 0.0000826144d },
            { 1759000.0d, 0.0000817291d },
            { 1772000.0d, 0.0000808372d },
            { 1785000.0d, 0.0000799392d },
            { 1798000.0d, 0.0000790358d },
            { 1811000.0d, 0.0000781275d },
            { 1824000.0d, 0.000077215d },
            { 1837000.0d, 0.0000762991d },
            { 1850000.0d, 0.0000753802d },
            { 1863000.0d, 0.000074459d },
            { 1876000.0d, 0.0000735362d },
            { 1889000.0d, 0.0000726125d },
            { 1902000.0d, 0.0000716885d },
            { 1915000.0d, 0.000070765d },
            { 1928000.0d, 0.0000698424d },
            { 1941000.0d, 0.0000689217d },
            { 1954000.0d, 0.0000680034d },
            { 1967000.0d, 0.0000670881d },
            { 1980000.0d, 0.0000661767d },
            { 1993000.0d, 0.0000652699d },
            { 2006000.0d, 0.0000643683d },
            { 2019000.0d, 0.0000634726d },
            { 2032000.0d, 0.0000625835d },
            { 2045000.0d, 0.0000617019d },
            { 2058000.0d, 0.0000608284d },
            { 2071000.0d, 0.0000599637d },
            { 2084000.0d, 0.0000591086d },
            { 2097000.0d, 0.0000582639d },
            { 2110000.0d, 0.0000574303d },
            { 2123000.0d, 0.0000566084d },
            { 2136000.0d, 0.0000557991d },
            { 2149000.0d, 0.0000550033d },
            { 2162000.0d, 0.0000542216d },
            { 2175000.0d, 0.0000534548d },
            { 2188000.0d, 0.0000527035d },
            { 2201000.0d, 0.0000519688d },
            { 2214000.0d, 0.0000512513d },
            { 2227000.0d, 0.0000505519d },
            { 2240000.0d, 0.0000498712d },
            { 2253000.0d, 0.0000492103d },
            { 2266000.0d, 0.0000485697d },
            { 2279000.0d, 0.0000479503d },
            { 2292000.0d, 0.000047353d },
            { 2305000.0d, 0.0000467785d },
            { 2318000.0d, 0.0000462275d },
            { 2331000.0d, 0.0000456999d },
            { 2344000.0d, 0.0000451886d },
            { 2357000.0d, 0.0000446926d },
            { 2370000.0d, 0.0000442125d },
            { 2383000.0d, 0.0000437478d },
            { 2396000.0d, 0.0000432936d },
            { 2409000.0d, 0.0000428478d },
            { 2422000.0d, 0.0000424072d },
            { 2435000.0d, 0.0000419703d },
            { 2448000.0d, 0.0000415377d },
            { 2461000.0d, 0.0000411094d },
            { 2474000.0d, 0.0000406859d },
            { 2487000.0d, 0.0000402672d },
            { 2500000.0d, 0.0000398537d },
            { 2513000.0d, 0.0000394458d },
            { 2526000.0d, 0.0000390432d },
            { 2539000.0d, 0.0000386398d },
            { 2552000.0d, 0.0000382331d },
            { 2565000.0d, 0.0000378229d },
            { 2578000.0d, 0.0000374093d },
            { 2591000.0d, 0.0000369926d },
            { 2604000.0d, 0.0000365728d },
            { 2617000.0d, 0.0000361498d },
            { 2630000.0d, 0.0000357239d },
            { 2643000.0d, 0.000035295d },
            { 2656000.0d, 0.0000348633d },
            { 2669000.0d, 0.0000344289d },
            { 2682000.0d, 0.0000339918d },
            { 2695000.0d, 0.0000335521d },
            { 2708000.0d, 0.0000331099d },
            { 2721000.0d, 0.0000326654d },
            { 2734000.0d, 0.0000322186d },
            { 2747000.0d, 0.0000317695d },
            { 2760000.0d, 0.0000313183d },
            { 2773000.0d, 0.0000308651d },
            { 2786000.0d, 0.00003041d },
            { 2799000.0d, 0.0000299531d },
            { 2812000.0d, 0.0000294944d },
            { 2825000.0d, 0.0000290342d },
            { 2838000.0d, 0.0000285724d },
            { 2851000.0d, 0.0000281092d },
            { 2864000.0d, 0.0000276447d },
            { 2877000.0d, 0.000027179d },
            { 2890000.0d, 0.0000267123d },
            { 2903000.0d, 0.0000262446d },
            { 2916000.0d, 0.000025776d },
            { 2929000.0d, 0.0000253067d },
            { 2942000.0d, 0.0000248368d },
            { 2955000.0d, 0.0000243664d },
            { 2968000.0d, 0.0000238957d },
            { 2981000.0d, 0.0000234246d },
            { 2994000.0d, 0.0000229536d },
            { 3007000.0d, 0.0000224826d },
            { 3020000.0d, 0.0000220116d },
            { 3033000.0d, 0.0000215409d },
            { 3046000.0d, 0.0000210707d },
            { 3059000.0d, 0.0000206012d },
            { 3072000.0d, 0.0000201322d },
            { 3085000.0d, 0.0000196641d },
            { 3098000.0d, 0.000019197d },
            { 3111000.0d, 0.0000187311d },
            { 3124000.0d, 0.0000182666d },
            { 3137000.0d, 0.0000178034d },
            { 3150000.0d, 0.0000173418d },
            { 3163000.0d, 0.0000168822d },
            { 3176000.0d, 0.0000164243d },
            { 3189000.0d, 0.0000159686d },
            { 3202000.0d, 0.0000155152d },
            { 3215000.0d, 0.0000150642d },
            { 3228000.0d, 0.0000146158d },
            { 3241000.0d, 0.0000141702d },
            { 3254000.0d, 0.0000137276d },
            { 3267000.0d, 0.0000132882d },
            { 3280000.0d, 0.0000128521d },
            { 3293000.0d, 0.0000124196d },
            { 3306000.0d, 0.0000119908d },
            { 3319000.0d, 0.0000115659d },
            { 3332000.0d, 0.0000111451d },
            { 3345000.0d, 0.0000107287d },
            { 3358000.0d, 0.0000103168d },
            { 3371000.0d, 0.00000990964d },
            { 3384000.0d, 0.00000950744d },
            { 3397000.0d, 0.0000091104d },
            { 3410000.0d, 0.00000871875d },
            { 3423000.0d, 0.00000833271d },
            { 3436000.0d, 0.00000795251d },
            { 3449000.0d, 0.00000757836d },
            { 3462000.0d, 0.00000721053d },
            { 3475000.0d, 0.00000684922d },
            { 3488000.0d, 0.0000064947d },
            { 3501000.0d, 0.00000614719d },
            { 3514000.0d, 0.00000580695d },
            { 3527000.0d, 0.00000547423d },
            { 3540000.0d, 0.00000514928d },
            { 3553000.0d, 0.00000483237d },
            { 3566000.0d, 0.00000452377d },
            { 3579000.0d, 0.00000422373d },
            { 3592000.0d, 0.00000393251d },
            { 3605000.0d, 0.00000365042d },
            { 3618000.0d, 0.00000337771d },
            { 3631000.0d, 0.00000311469d },
            { 3644000.0d, 0.0000028616d },
            { 3657000.0d, 0.00000261878d },
            { 3670000.0d, 0.00000238649d },
            { 3683000.0d, 0.00000216505d },
            { 3696000.0d, 0.00000195475d },
            { 3709000.0d, 0.0000017559d },
            { 3722000.0d, 0.00000156881d },
            { 3735000.0d, 0.00000139378d },
            { 3748000.0d, 0.00000123113d },
            { 3761000.0d, 0.00000108117d },
            { 3774000.0d, 0.000000944209d },
            { 3787000.0d, 0.000000820517d },
            { 3800000.0d, 0.000000707045d },
            { 3813000.0d, 0.000000601494d },
            { 3826000.0d, 0.000000503999d },
            { 3839000.0d, 0.000000414693d },
            { 3852000.0d, 0.000000333714d },
            { 3865000.0d, 0.000000261194d },
            { 3878000.0d, 0.000000197266d },
            { 3891000.0d, 0.000000142064d },
            { 3904000.0d, 0.0000000957173d },
            { 3917000.0d, 0.0000000583536d },
            { 3930000.0d, 0.0000000300967d },
            { 3943000.0d, 0.0000000110627d },
            { 3956000.0d, 0.00000000134885d },
            { 3963000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    