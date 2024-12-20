using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium116";
        public override double halfLife { get; } = 11.8d;
        public override double atomicWeight { get; } = 115.9143d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver116()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.0385d, new GammaParticle(23700.0, 0.05231)), new(0.07777d, new GammaParticle(91000.0, 0.01362)), new(0.07854d, new GammaParticle(101200.0, 0.01225)), new(0.77d, new GammaParticle(114700.0, 0.01081)), new(0.11396d, new GammaParticle(178000.0, 0.00697)), new(0.01848d, new GammaParticle(216100.0, 0.00574)), new(0.06083d, new GammaParticle(278300.0, 0.00446)), new(0.03157d, new GammaParticle(302600.0, 0.0041)), new(0.011000000000000001d, new GammaParticle(3218.0, 0.38528)), new(0.031d, new GammaParticle(21990.0, 0.05638)), new(0.06d, new GammaParticle(22163.0, 0.05594)), new(0.016d, new GammaParticle(25030.0, 0.04953)), new(0.019d, new GammaParticle(25211.0, 0.04918)), new(0.0028000000000000004d, new GammaParticle(25454.0, 0.04871)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000242258d },
            { 7000.0d, 0.000246944d },
            { 14000.0d, 0.000251533d },
            { 21000.0d, 0.000256024d },
            { 28000.0d, 0.000260493d },
            { 35000.0d, 0.000265024d },
            { 42000.0d, 0.000269638d },
            { 49000.0d, 0.000274337d },
            { 56000.0d, 0.000279114d },
            { 63000.0d, 0.000283958d },
            { 70000.0d, 0.000288861d },
            { 77000.0d, 0.000293812d },
            { 84000.0d, 0.000298804d },
            { 91000.0d, 0.00030383d },
            { 98000.0d, 0.000308884d },
            { 105000.0d, 0.000313957d },
            { 113000.0d, 0.000319776d },
            { 121000.0d, 0.000325609d },
            { 129000.0d, 0.000331451d },
            { 137000.0d, 0.000337298d },
            { 145000.0d, 0.000343143d },
            { 153000.0d, 0.000348986d },
            { 161000.0d, 0.000354819d },
            { 169000.0d, 0.000360642d },
            { 177000.0d, 0.000366451d },
            { 185000.0d, 0.000372243d },
            { 193000.0d, 0.000378016d },
            { 201000.0d, 0.000383767d },
            { 209000.0d, 0.000389495d },
            { 217000.0d, 0.000395197d },
            { 225000.0d, 0.000400871d },
            { 233000.0d, 0.000406516d },
            { 241000.0d, 0.00041213d },
            { 249000.0d, 0.000417711d },
            { 257000.0d, 0.000423256d },
            { 265000.0d, 0.000428767d },
            { 273000.0d, 0.00043424d },
            { 281000.0d, 0.000439674d },
            { 289000.0d, 0.000445067d },
            { 297000.0d, 0.00045042d },
            { 305000.0d, 0.000455729d },
            { 313000.0d, 0.000460995d },
            { 321000.0d, 0.000466214d },
            { 329000.0d, 0.000471388d },
            { 337000.0d, 0.000476514d },
            { 345000.0d, 0.00048159d },
            { 353000.0d, 0.000486618d },
            { 361000.0d, 0.000491594d },
            { 369000.0d, 0.000496519d },
            { 377000.0d, 0.00050139d },
            { 385000.0d, 0.000506207d },
            { 393000.0d, 0.000510971d },
            { 401000.0d, 0.000515678d },
            { 409000.0d, 0.000520328d },
            { 417000.0d, 0.000524921d },
            { 425000.0d, 0.000529455d },
            { 433000.0d, 0.000533931d },
            { 441000.0d, 0.000538346d },
            { 449000.0d, 0.000542699d },
            { 457000.0d, 0.000546991d },
            { 465000.0d, 0.000551221d },
            { 473000.0d, 0.000555388d },
            { 481000.0d, 0.00055949d },
            { 489000.0d, 0.000563528d },
            { 497000.0d, 0.0005675d },
            { 505000.0d, 0.000571406d },
            { 513000.0d, 0.000575246d },
            { 521000.0d, 0.000579018d },
            { 529000.0d, 0.000582723d },
            { 537000.0d, 0.000586359d },
            { 545000.0d, 0.000589924d },
            { 553000.0d, 0.00059342d },
            { 561000.0d, 0.000596847d },
            { 569000.0d, 0.000600203d },
            { 577000.0d, 0.000603487d },
            { 585000.0d, 0.000606698d },
            { 593000.0d, 0.000609838d },
            { 601000.0d, 0.000612905d },
            { 609000.0d, 0.000615897d },
            { 617000.0d, 0.000618817d },
            { 625000.0d, 0.000621662d },
            { 633000.0d, 0.000624432d },
            { 641000.0d, 0.000627127d },
            { 649000.0d, 0.000629746d },
            { 657000.0d, 0.000632292d },
            { 665000.0d, 0.000634759d },
            { 673000.0d, 0.00063715d },
            { 681000.0d, 0.000639464d },
            { 689000.0d, 0.000641702d },
            { 697000.0d, 0.000643862d },
            { 705000.0d, 0.000645944d },
            { 713000.0d, 0.000647947d },
            { 721000.0d, 0.000649873d },
            { 729000.0d, 0.00065172d },
            { 737000.0d, 0.000653489d },
            { 745000.0d, 0.000655178d },
            { 753000.0d, 0.000656789d },
            { 761000.0d, 0.000658319d },
            { 769000.0d, 0.000659771d },
            { 777000.0d, 0.000661142d },
            { 785000.0d, 0.000662435d },
            { 793000.0d, 0.000663647d },
            { 801000.0d, 0.00066478d },
            { 809000.0d, 0.000665832d },
            { 817000.0d, 0.000666804d },
            { 825000.0d, 0.000667696d },
            { 833000.0d, 0.000668508d },
            { 841000.0d, 0.000669238d },
            { 849000.0d, 0.000669889d },
            { 857000.0d, 0.00067046d },
            { 865000.0d, 0.00067095d },
            { 873000.0d, 0.00067136d },
            { 881000.0d, 0.000671689d },
            { 889000.0d, 0.000671939d },
            { 897000.0d, 0.000672109d },
            { 905000.0d, 0.000672197d },
            { 913000.0d, 0.000672207d },
            { 921000.0d, 0.000672136d },
            { 929000.0d, 0.000671986d },
            { 937000.0d, 0.000671755d },
            { 945000.0d, 0.000671445d },
            { 953000.0d, 0.000671056d },
            { 961000.0d, 0.000670588d },
            { 969000.0d, 0.000670041d },
            { 977000.0d, 0.000669414d },
            { 985000.0d, 0.000668709d },
            { 993000.0d, 0.000667927d },
            { 1001000.0d, 0.000667065d },
            { 1009000.0d, 0.000666126d },
            { 1017000.0d, 0.000665109d },
            { 1025000.0d, 0.000664015d },
            { 1033000.0d, 0.000662843d },
            { 1041000.0d, 0.000661595d },
            { 1049000.0d, 0.00066027d },
            { 1057000.0d, 0.000658869d },
            { 1065000.0d, 0.000657393d },
            { 1073000.0d, 0.000655842d },
            { 1081000.0d, 0.000654214d },
            { 1089000.0d, 0.000652512d },
            { 1097000.0d, 0.000650736d },
            { 1105000.0d, 0.000648885d },
            { 1113000.0d, 0.000646963d },
            { 1121000.0d, 0.000644965d },
            { 1129000.0d, 0.000642897d },
            { 1137000.0d, 0.000640755d },
            { 1145000.0d, 0.000638541d },
            { 1153000.0d, 0.000636258d },
            { 1161000.0d, 0.000633903d },
            { 1169000.0d, 0.000631477d },
            { 1177000.0d, 0.000628982d },
            { 1185000.0d, 0.000626418d },
            { 1193000.0d, 0.000623786d },
            { 1201000.0d, 0.000621085d },
            { 1209000.0d, 0.000618317d },
            { 1217000.0d, 0.000615482d },
            { 1225000.0d, 0.000612579d },
            { 1233000.0d, 0.000609613d },
            { 1241000.0d, 0.00060658d },
            { 1249000.0d, 0.000603483d },
            { 1257000.0d, 0.000600323d },
            { 1265000.0d, 0.000597098d },
            { 1273000.0d, 0.000593812d },
            { 1281000.0d, 0.000590463d },
            { 1289000.0d, 0.000587055d },
            { 1297000.0d, 0.000583585d },
            { 1305000.0d, 0.000580056d },
            { 1313000.0d, 0.000576467d },
            { 1321000.0d, 0.000572821d },
            { 1329000.0d, 0.000569116d },
            { 1337000.0d, 0.000565355d },
            { 1345000.0d, 0.000561538d },
            { 1353000.0d, 0.000557666d },
            { 1361000.0d, 0.00055374d },
            { 1369000.0d, 0.00054976d },
            { 1377000.0d, 0.000545727d },
            { 1385000.0d, 0.000541641d },
            { 1393000.0d, 0.000537507d },
            { 1401000.0d, 0.00053332d },
            { 1409000.0d, 0.000529085d },
            { 1417000.0d, 0.000524801d },
            { 1425000.0d, 0.00052047d },
            { 1433000.0d, 0.000516092d },
            { 1441000.0d, 0.000511669d },
            { 1449000.0d, 0.0005072d },
            { 1457000.0d, 0.000502687d },
            { 1465000.0d, 0.000498133d },
            { 1473000.0d, 0.000493536d },
            { 1481000.0d, 0.000488897d },
            { 1489000.0d, 0.000484219d },
            { 1497000.0d, 0.000479502d },
            { 1505000.0d, 0.000474747d },
            { 1513000.0d, 0.000469954d },
            { 1521000.0d, 0.000465127d },
            { 1529000.0d, 0.000460264d },
            { 1537000.0d, 0.000455368d },
            { 1545000.0d, 0.000450438d },
            { 1553000.0d, 0.000445477d },
            { 1561000.0d, 0.000440485d },
            { 1569000.0d, 0.000435465d },
            { 1577000.0d, 0.000430415d },
            { 1585000.0d, 0.000425338d },
            { 1593000.0d, 0.000420235d },
            { 1601000.0d, 0.000415108d },
            { 1609000.0d, 0.000409956d },
            { 1617000.0d, 0.000404782d },
            { 1625000.0d, 0.000399586d },
            { 1633000.0d, 0.000394369d },
            { 1641000.0d, 0.000389135d },
            { 1649000.0d, 0.000383882d },
            { 1657000.0d, 0.000378613d },
            { 1665000.0d, 0.000373328d },
            { 1673000.0d, 0.000368029d },
            { 1681000.0d, 0.000362717d },
            { 1689000.0d, 0.000357393d },
            { 1697000.0d, 0.000352059d },
            { 1705000.0d, 0.000346717d },
            { 1713000.0d, 0.000341366d },
            { 1721000.0d, 0.000336008d },
            { 1729000.0d, 0.000330646d },
            { 1737000.0d, 0.00032528d },
            { 1745000.0d, 0.000319912d },
            { 1753000.0d, 0.000314541d },
            { 1761000.0d, 0.000309172d },
            { 1769000.0d, 0.000303805d },
            { 1777000.0d, 0.000298439d },
            { 1785000.0d, 0.00029308d },
            { 1793000.0d, 0.000287725d },
            { 1801000.0d, 0.000282378d },
            { 1809000.0d, 0.00027704d },
            { 1817000.0d, 0.000271711d },
            { 1825000.0d, 0.000266394d },
            { 1833000.0d, 0.00026109d },
            { 1841000.0d, 0.000255801d },
            { 1849000.0d, 0.000250528d },
            { 1857000.0d, 0.000245272d },
            { 1865000.0d, 0.000240035d },
            { 1873000.0d, 0.000234818d },
            { 1881000.0d, 0.000229624d },
            { 1889000.0d, 0.000224453d },
            { 1897000.0d, 0.000219307d },
            { 1905000.0d, 0.000214189d },
            { 1913000.0d, 0.000209097d },
            { 1921000.0d, 0.000204036d },
            { 1929000.0d, 0.000199006d },
            { 1937000.0d, 0.000194009d },
            { 1945000.0d, 0.000189047d },
            { 1953000.0d, 0.00018412d },
            { 1961000.0d, 0.000179232d },
            { 1969000.0d, 0.000174383d },
            { 1977000.0d, 0.000169575d },
            { 1985000.0d, 0.00016481d },
            { 1993000.0d, 0.000160088d },
            { 2001000.0d, 0.000155413d },
            { 2009000.0d, 0.000150786d },
            { 2017000.0d, 0.000146208d },
            { 2025000.0d, 0.000141681d },
            { 2033000.0d, 0.000137207d },
            { 2041000.0d, 0.000132788d },
            { 2049000.0d, 0.000128424d },
            { 2057000.0d, 0.000124119d },
            { 2065000.0d, 0.000119874d },
            { 2073000.0d, 0.00011569d },
            { 2081000.0d, 0.000111569d },
            { 2089000.0d, 0.000107513d },
            { 2097000.0d, 0.000103524d },
            { 2105000.0d, 0.0000996029d },
            { 2113000.0d, 0.0000957509d },
            { 2121000.0d, 0.0000919689d },
            { 2129000.0d, 0.0000882588d },
            { 2137000.0d, 0.0000846223d },
            { 2145000.0d, 0.0000810613d },
            { 2153000.0d, 0.0000775773d },
            { 2161000.0d, 0.0000741725d },
            { 2169000.0d, 0.0000708485d },
            { 2177000.0d, 0.0000676072d },
            { 2185000.0d, 0.0000644503d },
            { 2193000.0d, 0.0000613795d },
            { 2201000.0d, 0.000058397d },
            { 2209000.0d, 0.0000555041d },
            { 2217000.0d, 0.0000527024d },
            { 2225000.0d, 0.0000499709d },
            { 2233000.0d, 0.0000472967d },
            { 2241000.0d, 0.0000446811d },
            { 2249000.0d, 0.0000421255d },
            { 2257000.0d, 0.0000396312d },
            { 2265000.0d, 0.0000371994d },
            { 2273000.0d, 0.0000348316d },
            { 2281000.0d, 0.0000325289d },
            { 2289000.0d, 0.0000302929d },
            { 2297000.0d, 0.0000281248d },
            { 2305000.0d, 0.0000260259d },
            { 2313000.0d, 0.0000239977d },
            { 2321000.0d, 0.0000220415d },
            { 2329000.0d, 0.0000201585d },
            { 2337000.0d, 0.0000183503d },
            { 2345000.0d, 0.0000166182d },
            { 2353000.0d, 0.0000149636d },
            { 2361000.0d, 0.0000133878d },
            { 2369000.0d, 0.0000118922d },
            { 2377000.0d, 0.0000104783d },
            { 2385000.0d, 0.00000914729d },
            { 2393000.0d, 0.00000790071d },
            { 2401000.0d, 0.00000673991d },
            { 2409000.0d, 0.00000566628d },
            { 2417000.0d, 0.00000468123d },
            { 2425000.0d, 0.00000378613d },
            { 2433000.0d, 0.00000298239d },
            { 2441000.0d, 0.00000227138d },
            { 2449000.0d, 0.00000165449d },
            { 2457000.0d, 0.00000113308d },
            { 2465000.0d, 0.000000708483d },
            { 2473000.0d, 0.000000382026d },
            { 2481000.0d, 0.000000154962d },
            { 2489000.0d, 0.0000000284288d },
            { 2495000.0d, 0d },

        }; 
    }
}
    