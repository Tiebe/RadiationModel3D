using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gadolinium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium144";
        public override double halfLife { get; } = 268.2d;
        public override double atomicWeight { get; } = 143.92296d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Samarium144()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(5.935e-05d, new GammaParticle(13800.0, 0.08984)), new(0.0005935d, new GammaParticle(203600.0, 0.00609)), new(0.00077155d, new GammaParticle(233300.0, 0.00531)), new(0.0005935d, new GammaParticle(257300.0, 0.00482)), new(0.00160245d, new GammaParticle(271100.0, 0.00457)), new(0.00492605d, new GammaParticle(274400.0, 0.00452)), new(0.0008309d, new GammaParticle(282400.0, 0.00439)), new(0.00124635d, new GammaParticle(288200.0, 0.0043)), new(0.05934999999999999d, new GammaParticle(333300.0, 0.00372)), new(0.016558649999999998d, new GammaParticle(347100.0, 0.00357)), new(0.0005935d, new GammaParticle(361600.0, 0.00343)), new(0.00183985d, new GammaParticle(450700.0, 0.00275)), new(0.0009496d, new GammaParticle(541200.0, 0.00229)), new(0.00183985d, new GammaParticle(560800.0, 0.00221)), new(0.0021366d, new GammaParticle(579900.0, 0.00214)), new(0.0016618d, new GammaParticle(603300.0, 0.00206)), new(0.0096147d, new GammaParticle(621500.0, 0.00199)), new(0.0192294d, new GammaParticle(629500.0, 0.00197)), new(0.007715499999999999d, new GammaParticle(641500.0, 0.00193)), new(0.0035610000000000004d, new GammaParticle(664000.0, 0.00187)), new(0.0010683d, new GammaParticle(740900.0, 0.00167)), new(0.0017211499999999999d, new GammaParticle(812300.0, 0.00153)), new(0.0100895d, new GammaParticle(868100.0, 0.00143)), new(0.00183985d, new GammaParticle(872700.0, 0.00142)), new(0.0037984d, new GammaParticle(907900.0, 0.00137)), new(0.00445125d, new GammaParticle(956900.0, 0.0013)), new(0.0032642500000000002d, new GammaParticle(974800.0, 0.00127)), new(0.0004748d, new GammaParticle(1030400.0, 0.0012)), new(0.00243335d, new GammaParticle(1055100.0, 0.00118)), new(0.00373905d, new GammaParticle(1128600.0, 0.0011)), new(0.00243335d, new GammaParticle(1139100.0, 0.00109)), new(0.0015431d, new GammaParticle(1145600.0, 0.00108)), new(0.0020179d, new GammaParticle(1201400.0, 0.00103)), new(0.0013057d, new GammaParticle(1226600.0, 0.00101)), new(0.008309d, new GammaParticle(1231200.0, 0.00101)), new(0.0030268499999999998d, new GammaParticle(1287000.0, 0.00096)), new(0.00456995d, new GammaParticle(1293500.0, 0.00096)), new(0.001187d, new GammaParticle(1300700.0, 0.00095)), new(0.0009496d, new GammaParticle(1358400.0, 0.00091)), new(0.00183985d, new GammaParticle(1402400.0, 0.00088)), new(0.005935d, new GammaParticle(1457800.0, 0.00085)), new(0.0017211499999999999d, new GammaParticle(1511100.0, 0.00082)), new(0.0020179d, new GammaParticle(1524700.0, 0.00081)), new(0.0033236d, new GammaParticle(1559900.0, 0.00079)), new(0.0016618d, new GammaParticle(1583100.0, 0.00078)), new(0.001187d, new GammaParticle(1717900.0, 0.00072)), new(0.0070033000000000005d, new GammaParticle(1803100.0, 0.00069)), new(0.0034422999999999997d, new GammaParticle(1829800.0, 0.00068)), new(0.00160245d, new GammaParticle(2015000.0, 0.00062)), new(0.00077155d, new GammaParticle(2028800.0, 0.00061)), new(0.0021366d, new GammaParticle(2071200.0, 0.0006)), new(0.0020179d, new GammaParticle(2088100.0, 0.00059)), new(0.0032642500000000002d, new GammaParticle(2183100.0, 0.00057)), new(0.00278945d, new GammaParticle(2198400.0, 0.00056)), new(0.0084277d, new GammaParticle(2362100.0, 0.00052)), new(0.0562638d, new GammaParticle(2432600.0, 0.00051)), new(0.0014244000000000001d, new GammaParticle(2457500.0, 0.0005)), new(0.0124635d, new GammaParticle(2471300.0, 0.0005)), new(0.002374d, new GammaParticle(2494600.0, 0.0005)), new(0.0060536999999999995d, new GammaParticle(2692700.0, 0.00046)), new(0.0042732d, new GammaParticle(2709600.0, 0.00046)), new(0.0009496d, new GammaParticle(2804600.0, 0.00044)), new(0.0017211499999999999d, new GammaParticle(2827900.0, 0.00044)), new(0.000683083883357568d, new GammaParticle(6603.0, 0.18777)), new(0.0010723284071045048d, new GammaParticle(40901.0, 0.03031)), new(0.0019349123188460932d, new GammaParticle(41541.0, 0.02985)), new(0.0006095758228278239d, new GammaParticle(47146.0, 0.0263)), new(0.0007668463851174024d, new GammaParticle(47645.0, 0.02602)), new(0.00015727056228957855d, new GammaParticle(48248.0, 0.0257)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 100.0d, 0.000000642172d },
            { 200.0d, 0.0000010682d },
            { 300.0d, 0.00000154825d },
            { 400.0d, 0.00000208651d },
            { 500.0d, 0.00000269079d },
            { 600.0d, 0.00000336563d },
            { 700.0d, 0.0000041151d },
            { 800.0d, 0.00000494274d },
            { 900.0d, 0.00000585203d },
            { 1000.0d, 0.00000684585d },
            { 1500.0d, 0.0000131815d },
            { 2000.0d, 0.0000220238d },
            { 2500.0d, 0.0000336343d },
            { 3000.0d, 0.0000482076d },
            { 3500.0d, 0.0000658677d },
            { 4000.0d, 0.0000866654d },
            { 4500.0d, 0.000110577d },
            { 5000.0d, 0.000137505d },
            { 5500.0d, 0.000167282d },
            { 6000.0d, 0.000199674d },
            { 6500.0d, 0.00023438d },
            { 7000.0d, 0.000271042d },
            { 7500.0d, 0.000309253d },
            { 8000.0d, 0.000348559d },
            { 8500.0d, 0.000388469d },
            { 9000.0d, 0.000428465d },
            { 9500.0d, 0.000468003d },
            { 10000.0d, 0.000506532d },
            { 11000.0d, 0.000578316d },
            { 12000.0d, 0.000639417d },
            { 13000.0d, 0.000685746d },
            { 14000.0d, 0.000713771d },
            { 15000.0d, 0.000720761d },
            { 16000.0d, 0.000705011d },
            { 17000.0d, 0.000666047d },
            { 18000.0d, 0.000604824d },
            { 19000.0d, 0.000523895d },
            { 20000.0d, 0.000427549d },
            { 21000.0d, 0.000321966d },
            { 22000.0d, 0.000215327d },
            { 23000.0d, 0.000117917d },
            { 24000.0d, 0.0000422085d },
            { 25000.0d, 0.00000293907d },
            { 26000.0d, 0.000000793118d },
            { 27000.0d, 0.000000875329d },
            { 28000.0d, 0.000000964761d },
            { 29000.0d, 0.00000105904d },
            { 30000.0d, 0.00000115815d },
            { 31000.0d, 0.0000012621d },
            { 32000.0d, 0.00000137088d },
            { 33000.0d, 0.00000148448d },
            { 34000.0d, 0.00000160291d },
            { 35000.0d, 0.00000172617d },
            { 36000.0d, 0.00000185424d },
            { 37000.0d, 0.00000198699d },
            { 38000.0d, 0.00000212454d },
            { 39000.0d, 0.00000226687d },
            { 40000.0d, 0.00000241398d },
            { 41000.0d, 0.00000256586d },
            { 42000.0d, 0.00000272252d },
            { 43000.0d, 0.0000028839d },
            { 44000.0d, 0.00000305005d },
            { 45000.0d, 0.00000322095d },
            { 46000.0d, 0.00000339496d },
            { 47000.0d, 0.00000357339d },
            { 48000.0d, 0.00000375624d },
            { 49000.0d, 0.00000394347d },
            { 50000.0d, 0.00000413508d },
            { 51000.0d, 0.00000433108d },
            { 52000.0d, 0.00000453147d },
            { 53000.0d, 0.00000473624d },
            { 54000.0d, 0.00000494539d },
            { 55000.0d, 0.00000515668d },
            { 56000.0d, 0.00000537189d },
            { 57000.0d, 0.00000559098d },
            { 58000.0d, 0.00000581399d },
            { 59000.0d, 0.00000604091d },
            { 60000.0d, 0.00000627173d },
            { 61000.0d, 0.00000650641d },
            { 62000.0d, 0.00000674498d },
            { 63000.0d, 0.00000698744d },
            { 64000.0d, 0.00000723144d },
            { 65000.0d, 0.00000747884d },
            { 66000.0d, 0.00000772964d },
            { 67000.0d, 0.00000798382d },
            { 68000.0d, 0.0000082414d },
            { 69000.0d, 0.00000850236d },
            { 70000.0d, 0.00000876671d },
            { 71000.0d, 0.00000903441d },
            { 72000.0d, 0.00000930549d },
            { 73000.0d, 0.0000095777d },
            { 74000.0d, 0.00000985284d },
            { 75000.0d, 0.0000101309d },
            { 76000.0d, 0.0000104119d },
            { 77000.0d, 0.0000106957d },
            { 78000.0d, 0.0000109825d },
            { 79000.0d, 0.0000112722d },
            { 80000.0d, 0.0000115647d },
            { 81000.0d, 0.0000118601d },
            { 82000.0d, 0.0000121565d },
            { 83000.0d, 0.0000124553d },
            { 84000.0d, 0.0000127566d },
            { 85000.0d, 0.0000130603d },
            { 86000.0d, 0.0000133666d },
            { 87000.0d, 0.0000136752d },
            { 88000.0d, 0.0000139864d },
            { 89000.0d, 0.0000143d },
            { 90000.0d, 0.0000146161d },
            { 91000.0d, 0.0000149329d },
            { 92000.0d, 0.0000152517d },
            { 93000.0d, 0.0000155727d },
            { 94000.0d, 0.0000158957d },
            { 95000.0d, 0.0000162209d },
            { 96000.0d, 0.0000165481d },
            { 97000.0d, 0.0000168774d },
            { 98000.0d, 0.0000172088d },
            { 99000.0d, 0.0000175422d },
            { 100000.0d, 0.0000178762d },
            { 109000.0d, 0.0000209598d },
            { 118000.0d, 0.000024161d },
            { 127000.0d, 0.0000274601d },
            { 136000.0d, 0.0000308403d },
            { 145000.0d, 0.0000342873d },
            { 154000.0d, 0.0000377888d },
            { 163000.0d, 0.0000413343d },
            { 172000.0d, 0.0000449148d },
            { 181000.0d, 0.0000485224d },
            { 190000.0d, 0.0000521505d },
            { 199000.0d, 0.0000557933d },
            { 208000.0d, 0.0000594458d },
            { 217000.0d, 0.0000631038d },
            { 226000.0d, 0.0000667634d },
            { 235000.0d, 0.0000704215d },
            { 244000.0d, 0.0000740753d },
            { 253000.0d, 0.0000777225d },
            { 262000.0d, 0.000081361d },
            { 271000.0d, 0.0000849889d },
            { 280000.0d, 0.0000886049d },
            { 289000.0d, 0.0000922072d },
            { 298000.0d, 0.0000957911d },
            { 307000.0d, 0.0000993542d },
            { 316000.0d, 0.000102895d },
            { 325000.0d, 0.000106413d },
            { 334000.0d, 0.000109905d },
            { 343000.0d, 0.000113372d },
            { 352000.0d, 0.000116812d },
            { 361000.0d, 0.000120224d },
            { 370000.0d, 0.000123607d },
            { 379000.0d, 0.00012696d },
            { 388000.0d, 0.000130282d },
            { 397000.0d, 0.000133572d },
            { 406000.0d, 0.00013683d },
            { 415000.0d, 0.000140055d },
            { 424000.0d, 0.000143247d },
            { 433000.0d, 0.000146404d },
            { 442000.0d, 0.000149527d },
            { 451000.0d, 0.000152615d },
            { 460000.0d, 0.000155667d },
            { 469000.0d, 0.000158683d },
            { 478000.0d, 0.000161662d },
            { 487000.0d, 0.000164605d },
            { 496000.0d, 0.00016751d },
            { 505000.0d, 0.000170378d },
            { 514000.0d, 0.000173207d },
            { 523000.0d, 0.000175999d },
            { 532000.0d, 0.000178752d },
            { 541000.0d, 0.000181466d },
            { 550000.0d, 0.000184141d },
            { 559000.0d, 0.000186777d },
            { 568000.0d, 0.000189373d },
            { 577000.0d, 0.000191929d },
            { 586000.0d, 0.000194445d },
            { 595000.0d, 0.000196922d },
            { 604000.0d, 0.000199357d },
            { 613000.0d, 0.000201752d },
            { 622000.0d, 0.000204106d },
            { 631000.0d, 0.000206419d },
            { 640000.0d, 0.000208691d },
            { 649000.0d, 0.000210921d },
            { 658000.0d, 0.00021311d },
            { 667000.0d, 0.000215258d },
            { 676000.0d, 0.000217364d },
            { 685000.0d, 0.000219428d },
            { 694000.0d, 0.000221451d },
            { 703000.0d, 0.000223431d },
            { 712000.0d, 0.000225369d },
            { 721000.0d, 0.000227266d },
            { 730000.0d, 0.000229119d },
            { 739000.0d, 0.000230931d },
            { 748000.0d, 0.000232701d },
            { 757000.0d, 0.000234428d },
            { 766000.0d, 0.000236113d },
            { 775000.0d, 0.000237756d },
            { 784000.0d, 0.000239356d },
            { 793000.0d, 0.000240913d },
            { 802000.0d, 0.000242428d },
            { 811000.0d, 0.0002439d },
            { 820000.0d, 0.000245329d },
            { 829000.0d, 0.000246715d },
            { 838000.0d, 0.000248059d },
            { 847000.0d, 0.00024936d },
            { 856000.0d, 0.000250618d },
            { 865000.0d, 0.000251834d },
            { 874000.0d, 0.000253006d },
            { 883000.0d, 0.000254137d },
            { 892000.0d, 0.000255224d },
            { 901000.0d, 0.000256269d },
            { 910000.0d, 0.000257271d },
            { 919000.0d, 0.000258231d },
            { 928000.0d, 0.000259148d },
            { 937000.0d, 0.000260023d },
            { 946000.0d, 0.000260855d },
            { 955000.0d, 0.000261645d },
            { 964000.0d, 0.000262393d },
            { 973000.0d, 0.000263098d },
            { 982000.0d, 0.000263762d },
            { 991000.0d, 0.000264384d },
            { 1000000.0d, 0.000264962d },
            { 1009000.0d, 0.0002655d },
            { 1018000.0d, 0.000265996d },
            { 1027000.0d, 0.000266451d },
            { 1036000.0d, 0.000266864d },
            { 1045000.0d, 0.000267236d },
            { 1054000.0d, 0.000267567d },
            { 1063000.0d, 0.000267857d },
            { 1072000.0d, 0.000268105d },
            { 1081000.0d, 0.000268313d },
            { 1090000.0d, 0.000268481d },
            { 1099000.0d, 0.000268609d },
            { 1108000.0d, 0.000268696d },
            { 1117000.0d, 0.000268744d },
            { 1126000.0d, 0.000268752d },
            { 1135000.0d, 0.000268719d },
            { 1144000.0d, 0.000268648d },
            { 1153000.0d, 0.000268538d },
            { 1162000.0d, 0.000268388d },
            { 1171000.0d, 0.0002682d },
            { 1180000.0d, 0.000267972d },
            { 1189000.0d, 0.000267706d },
            { 1198000.0d, 0.000267402d },
            { 1207000.0d, 0.000267059d },
            { 1216000.0d, 0.000266679d },
            { 1225000.0d, 0.00026626d },
            { 1234000.0d, 0.000265805d },
            { 1243000.0d, 0.000265311d },
            { 1252000.0d, 0.000264782d },
            { 1261000.0d, 0.000264215d },
            { 1270000.0d, 0.000263611d },
            { 1279000.0d, 0.000262973d },
            { 1288000.0d, 0.000262297d },
            { 1297000.0d, 0.000261587d },
            { 1306000.0d, 0.00026084d },
            { 1315000.0d, 0.00026006d },
            { 1324000.0d, 0.000259244d },
            { 1333000.0d, 0.000258394d },
            { 1342000.0d, 0.000257509d },
            { 1351000.0d, 0.000256591d },
            { 1360000.0d, 0.000255639d },
            { 1369000.0d, 0.000254654d },
            { 1378000.0d, 0.000253637d },
            { 1387000.0d, 0.000252587d },
            { 1396000.0d, 0.000251504d },
            { 1405000.0d, 0.000250391d },
            { 1414000.0d, 0.000249245d },
            { 1423000.0d, 0.000248068d },
            { 1432000.0d, 0.00024686d },
            { 1441000.0d, 0.000245622d },
            { 1450000.0d, 0.000244353d },
            { 1459000.0d, 0.000243054d },
            { 1468000.0d, 0.000241725d },
            { 1477000.0d, 0.000240366d },
            { 1486000.0d, 0.000238977d },
            { 1495000.0d, 0.000237561d },
            { 1504000.0d, 0.000236116d },
            { 1513000.0d, 0.000234644d },
            { 1522000.0d, 0.000233143d },
            { 1531000.0d, 0.000231615d },
            { 1540000.0d, 0.00023006d },
            { 1549000.0d, 0.000228479d },
            { 1558000.0d, 0.00022687d },
            { 1567000.0d, 0.000225236d },
            { 1576000.0d, 0.000223576d },
            { 1585000.0d, 0.000221891d },
            { 1594000.0d, 0.000220181d },
            { 1603000.0d, 0.000218447d },
            { 1612000.0d, 0.000216689d },
            { 1621000.0d, 0.000214907d },
            { 1630000.0d, 0.000213101d },
            { 1639000.0d, 0.000211274d },
            { 1648000.0d, 0.000209424d },
            { 1657000.0d, 0.000207554d },
            { 1666000.0d, 0.000205661d },
            { 1675000.0d, 0.000203748d },
            { 1684000.0d, 0.000201814d },
            { 1693000.0d, 0.000199861d },
            { 1702000.0d, 0.000197889d },
            { 1711000.0d, 0.000195898d },
            { 1720000.0d, 0.000193888d },
            { 1729000.0d, 0.000191861d },
            { 1738000.0d, 0.000189816d },
            { 1747000.0d, 0.000187755d },
            { 1756000.0d, 0.000185678d },
            { 1765000.0d, 0.000183584d },
            { 1774000.0d, 0.000181475d },
            { 1783000.0d, 0.000179353d },
            { 1792000.0d, 0.000177216d },
            { 1801000.0d, 0.000175065d },
            { 1810000.0d, 0.000172901d },
            { 1819000.0d, 0.000170725d },
            { 1828000.0d, 0.000168536d },
            { 1837000.0d, 0.000166336d },
            { 1846000.0d, 0.000164124d },
            { 1855000.0d, 0.000161902d },
            { 1864000.0d, 0.00015967d },
            { 1873000.0d, 0.000157429d },
            { 1882000.0d, 0.000155179d },
            { 1891000.0d, 0.000152921d },
            { 1900000.0d, 0.000150655d },
            { 1909000.0d, 0.000148382d },
            { 1918000.0d, 0.000146102d },
            { 1927000.0d, 0.000143817d },
            { 1936000.0d, 0.000141527d },
            { 1945000.0d, 0.000139232d },
            { 1954000.0d, 0.000136933d },
            { 1963000.0d, 0.000134631d },
            { 1972000.0d, 0.000132325d },
            { 1981000.0d, 0.000130018d },
            { 1990000.0d, 0.000127709d },
            { 1999000.0d, 0.000125399d },
            { 2008000.0d, 0.000123089d },
            { 2017000.0d, 0.000120779d },
            { 2026000.0d, 0.000118471d },
            { 2035000.0d, 0.000116164d },
            { 2044000.0d, 0.000113861d },
            { 2053000.0d, 0.00011156d },
            { 2062000.0d, 0.000109264d },
            { 2071000.0d, 0.000106971d },
            { 2080000.0d, 0.000104684d },
            { 2089000.0d, 0.000102403d },
            { 2098000.0d, 0.000100129d },
            { 2107000.0d, 0.0000978618d },
            { 2116000.0d, 0.0000956015d },
            { 2125000.0d, 0.000093349d },
            { 2134000.0d, 0.0000911049d },
            { 2143000.0d, 0.0000888699d },
            { 2152000.0d, 0.0000866447d },
            { 2161000.0d, 0.0000844301d },
            { 2170000.0d, 0.0000822269d },
            { 2179000.0d, 0.0000800356d },
            { 2188000.0d, 0.000077857d },
            { 2197000.0d, 0.000075692d },
            { 2206000.0d, 0.0000735411d },
            { 2215000.0d, 0.0000714053d },
            { 2224000.0d, 0.0000692852d },
            { 2233000.0d, 0.0000671817d },
            { 2242000.0d, 0.0000650954d },
            { 2251000.0d, 0.0000630272d },
            { 2260000.0d, 0.0000609778d },
            { 2269000.0d, 0.000058948d },
            { 2278000.0d, 0.0000569387d },
            { 2287000.0d, 0.0000549505d },
            { 2296000.0d, 0.0000529844d },
            { 2305000.0d, 0.000051041d },
            { 2314000.0d, 0.0000491214d },
            { 2323000.0d, 0.000047226d },
            { 2332000.0d, 0.0000453561d },
            { 2341000.0d, 0.0000435121d },
            { 2350000.0d, 0.000041695d },
            { 2359000.0d, 0.0000399057d },
            { 2368000.0d, 0.0000381449d },
            { 2377000.0d, 0.0000364135d },
            { 2386000.0d, 0.0000347124d },
            { 2395000.0d, 0.0000330417d },
            { 2404000.0d, 0.0000314017d },
            { 2413000.0d, 0.0000297934d },
            { 2422000.0d, 0.0000282175d },
            { 2431000.0d, 0.0000266749d },
            { 2440000.0d, 0.0000251663d },
            { 2449000.0d, 0.0000236927d },
            { 2458000.0d, 0.0000222548d },
            { 2467000.0d, 0.0000208536d },
            { 2476000.0d, 0.0000194898d },
            { 2485000.0d, 0.0000181643d },
            { 2494000.0d, 0.000016878d },
            { 2503000.0d, 0.0000156316d },
            { 2512000.0d, 0.0000144262d },
            { 2521000.0d, 0.0000132625d },
            { 2530000.0d, 0.0000121415d },
            { 2539000.0d, 0.0000110639d },
            { 2548000.0d, 0.0000100306d },
            { 2557000.0d, 0.00000904264d },
            { 2566000.0d, 0.00000810075d },
            { 2575000.0d, 0.00000720585d },
            { 2584000.0d, 0.00000635883d },
            { 2593000.0d, 0.00000556058d },
            { 2602000.0d, 0.00000481197d },
            { 2611000.0d, 0.0000041139d },
            { 2620000.0d, 0.00000346727d },
            { 2629000.0d, 0.00000287295d },
            { 2638000.0d, 0.00000233185d },
            { 2647000.0d, 0.00000184484d },
            { 2656000.0d, 0.00000141282d },
            { 2665000.0d, 0.00000103667d },
            { 2674000.0d, 0.000000717253d },
            { 2683000.0d, 0.000000455445d },
            { 2692000.0d, 0.000000252086d },
            { 2701000.0d, 0.00000010799d },
            { 2710000.0d, 0.0000000239053d },
            { 2718000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    