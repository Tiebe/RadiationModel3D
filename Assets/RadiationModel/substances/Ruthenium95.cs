using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ruthenium95 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium95";
        public override double halfLife { get; } = 5914.8d;
        public override double atomicWeight { get; } = 94.9104d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum95()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00049355d, new GammaParticle(157400.0, 0.00788)), new(0.00217162d, new GammaParticle(254580.0, 0.00487)), new(0.03681883d, new GammaParticle(290380.0, 0.00427)), new(0.021025230000000002d, new GammaParticle(301010.0, 0.00412)), new(0.00217162d, new GammaParticle(312600.0, 0.00397)), new(2.46775e-05d, new GammaParticle(331380.0, 0.00374)), new(0.6988668d, new GammaParticle(336400.0, 0.00369)), new(0.00207291d, new GammaParticle(348200.0, 0.00356)), new(0.000276388d, new GammaParticle(403800.0, 0.00307)), new(0.0006909700000000001d, new GammaParticle(421300.0, 0.00294)), new(0.00078968d, new GammaParticle(446400.0, 0.00278)), new(0.000542905d, new GammaParticle(458000.0, 0.00271)), new(0.00049355d, new GammaParticle(477300.0, 0.0026)), new(0.00118452d, new GammaParticle(504800.0, 0.00246)), new(0.01697812d, new GammaParticle(551620.0, 0.00225)), new(0.00049355d, new GammaParticle(560000.0, 0.00221)), new(0.000414582d, new GammaParticle(564090.0, 0.0022)), new(0.00128323d, new GammaParticle(572400.0, 0.00217)), new(0.00039484d, new GammaParticle(576100.0, 0.00215)), new(0.00059226d, new GammaParticle(580800.0, 0.00213)), new(0.0118452d, new GammaParticle(591420.0, 0.0021)), new(0.00078968d, new GammaParticle(606300.0, 0.00204)), new(0.0019742d, new GammaParticle(607300.0, 0.00204)), new(0.177678d, new GammaParticle(626830.0, 0.00198)), new(0.00128323d, new GammaParticle(628000.0, 0.00197)), new(0.01016713d, new GammaParticle(652810.0, 0.0019)), new(0.000414582d, new GammaParticle(662200.0, 0.00187)), new(0.00078968d, new GammaParticle(689300.0, 0.0018)), new(0.00177678d, new GammaParticle(711540.0, 0.00174)), new(0.00463937d, new GammaParticle(735100.0, 0.00169)), new(0.01608973d, new GammaParticle(748500.0, 0.00166)), new(0.00217162d, new GammaParticle(755860.0, 0.00164)), new(0.00049355d, new GammaParticle(786800.0, 0.00158)), new(0.040372389999999994d, new GammaParticle(806280.0, 0.00154)), new(0.006416150000000001d, new GammaParticle(819070.0, 0.00151)), new(0.0006909700000000001d, new GammaParticle(834400.0, 0.00149)), new(0.01263488d, new GammaParticle(842160.0, 0.00147)), new(0.0006909700000000001d, new GammaParticle(847600.0, 0.00146)), new(0.00217162d, new GammaParticle(876700.0, 0.00141)), new(0.01905103d, new GammaParticle(889000.0, 0.00139)), new(0.00177678d, new GammaParticle(891000.0, 0.00139)), new(0.00157936d, new GammaParticle(893300.0, 0.00139)), new(0.000414582d, new GammaParticle(956600.0, 0.0013)), new(0.00217162d, new GammaParticle(960100.0, 0.00129)), new(0.00059226d, new GammaParticle(975900.0, 0.00127)), new(0.0070084100000000005d, new GammaParticle(989720.0, 0.00125)), new(0.000266517d, new GammaParticle(992300.0, 0.00125)), new(0.00720583d, new GammaParticle(1010570.0, 0.00123)), new(0.02596073d, new GammaParticle(1050680.0, 0.00118)), new(0.00740325d, new GammaParticle(1064390.0, 0.00116)), new(0.000306001d, new GammaParticle(1084980.0, 0.00114)), new(0.00217162d, new GammaParticle(1088900.0, 0.00114)), new(0.2092652d, new GammaParticle(1096800.0, 0.00113)), new(0.00118452d, new GammaParticle(1100000.0, 0.00113)), new(0.00207291d, new GammaParticle(1104300.0, 0.00112)), new(0.0005132919999999999d, new GammaParticle(1118690.0, 0.00111)), new(0.00937745d, new GammaParticle(1120110.0, 0.00111)), new(0.00839035d, new GammaParticle(1158400.0, 0.00107)), new(0.0070084100000000005d, new GammaParticle(1158400.0, 0.00107)), new(0.051329200000000005d, new GammaParticle(1178700.0, 0.00105)), new(0.00217162d, new GammaParticle(1182800.0, 0.00105)), new(0.000227033d, new GammaParticle(1213100.0, 0.00102)), new(0.0009871d, new GammaParticle(1220400.0, 0.00102)), new(0.00034548500000000003d, new GammaParticle(1236500.0, 0.001)), new(0.00078968d, new GammaParticle(1240400.0, 0.001)), new(0.00039484d, new GammaParticle(1243600.0, 0.001)), new(0.00325743d, new GammaParticle(1261360.0, 0.00098)), new(0.000138194d, new GammaParticle(1295800.0, 0.00096)), new(0.000138194d, new GammaParticle(1324000.0, 0.00094)), new(0.00246775d, new GammaParticle(1339620.0, 0.00093)), new(0.00848906d, new GammaParticle(1351900.0, 0.00092)), new(0.00779809d, new GammaParticle(1355100.0, 0.00091)), new(0.00029613d, new GammaParticle(1400800.0, 0.00089)), new(0.000898261d, new GammaParticle(1407550.0, 0.00088)), new(0.02477621d, new GammaParticle(1410630.0, 0.00088)), new(0.00032574300000000003d, new GammaParticle(1418700.0, 0.00087)), new(0.006416150000000001d, new GammaParticle(1433280.0, 0.00087)), new(0.00128323d, new GammaParticle(1448930.0, 0.00086)), new(0.02092652d, new GammaParticle(1459320.0, 0.00085)), new(0.000276388d, new GammaParticle(1522000.0, 0.00081)), new(0.0027638800000000002d, new GammaParticle(1541300.0, 0.0008)), new(0.00157936d, new GammaParticle(1562300.0, 0.00079)), new(0.00088839d, new GammaParticle(1625100.0, 0.00076)), new(0.00019742d, new GammaParticle(1632400.0, 0.00076)), new(0.0009871d, new GammaParticle(1642000.0, 0.00076)), new(0.00088839d, new GammaParticle(1691400.0, 0.00073)), new(0.00118452d, new GammaParticle(1697600.0, 0.00073)), new(0.000977229d, new GammaParticle(1702000.0, 0.00073)), new(0.00039484d, new GammaParticle(1747000.0, 0.00071)), new(0.000138194d, new GammaParticle(1756100.0, 0.00071)), new(0.0059226d, new GammaParticle(1785400.0, 0.00069)), new(0.00034548500000000003d, new GammaParticle(1814300.0, 0.00068)), new(0.00236904d, new GammaParticle(1831900.0, 0.00068)), new(0.000276388d, new GammaParticle(1837500.0, 0.00067)), new(0.00118452d, new GammaParticle(1852800.0, 0.00067)), new(0.00286259d, new GammaParticle(1931100.0, 0.00064)), new(0.000138194d, new GammaParticle(1978300.0, 0.00063)), new(0.00671228d, new GammaParticle(1988100.0, 0.00062)), new(0.0034548499999999998d, new GammaParticle(2047100.0, 0.00061)), new(0.000454066d, new GammaParticle(2168100.0, 0.00057)), new(0.00040471100000000004d, new GammaParticle(2189300.0, 0.00057)), new(0.00355356d, new GammaParticle(2252000.0, 0.00055)), new(0.00088839d, new GammaParticle(2267600.0, 0.00055)), new(0.000236904d, new GammaParticle(2290000.0, 0.00054)), new(0.014016820000000001d, new GammaParticle(2324500.0, 0.00053)), new(9.871e-05d, new GammaParticle(2382500.0, 0.00052)), new(9.871e-05d, new GammaParticle(2410200.0, 0.00051)), new(0.27916538d, new GammaParticle(511000.0, 0.00243)), new(0.03560048775488953d, new GammaParticle(2586.0, 0.47944)), new(0.16887494754003327d, new GammaParticle(18250.0, 0.06794)), new(0.3211160820308676d, new GammaParticle(18367.0, 0.0675)), new(0.08534645135099371d, new GammaParticle(20695.0, 0.05991)), new(0.0988311906644507d, new GammaParticle(20820.0, 0.05955)), new(0.013484739313457006d, new GammaParticle(21003.0, 0.05903)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 300.0d, 0.0000000000284867d },
            { 600.0d, 0.0000000000878124d },
            { 900.0d, 0.000000000181434d },
            { 1200.0d, 0.000000000311028d },
            { 1700.0d, 0.00000000116397d },
            { 2200.0d, 0.00000000607973d },
            { 2700.0d, 0.0000000155335d },
            { 3200.0d, 0.0000000280203d },
            { 3700.0d, 0.0000000435778d },
            { 4200.0d, 0.0000000622111d },
            { 4700.0d, 0.0000000839534d },
            { 5200.0d, 0.000000108808d },
            { 5700.0d, 0.000000136803d },
            { 6200.0d, 0.000000168229d },
            { 6700.0d, 0.000000203414d },
            { 7200.0d, 0.000000241991d },
            { 7700.0d, 0.000000283975d },
            { 8200.0d, 0.000000331481d },
            { 8700.0d, 0.000000386457d },
            { 9200.0d, 0.000000446274d },
            { 9700.0d, 0.000000511114d },
            { 10000.0d, 0.000000552325d },
            { 11000.0d, 0.000000702218d },
            { 12000.0d, 0.000000871362d },
            { 13000.0d, 0.00000106489d },
            { 14000.0d, 0.00000127973d },
            { 15000.0d, 0.00000151584d },
            { 16000.0d, 0.00000177316d },
            { 17000.0d, 0.00000205147d },
            { 18000.0d, 0.00000235083d },
            { 19000.0d, 0.00000267091d },
            { 20000.0d, 0.00000301178d },
            { 21000.0d, 0.00000337067d },
            { 22000.0d, 0.00000374875d },
            { 23000.0d, 0.00000414614d },
            { 24000.0d, 0.0000045628d },
            { 25000.0d, 0.00000499438d },
            { 26000.0d, 0.00000544334d },
            { 27000.0d, 0.00000590964d },
            { 28000.0d, 0.00000639271d },
            { 29000.0d, 0.00000688864d },
            { 30000.0d, 0.00000739985d },
            { 31000.0d, 0.00000792581d },
            { 32000.0d, 0.00000846669d },
            { 33000.0d, 0.00000901846d },
            { 34000.0d, 0.000009583d },
            { 35000.0d, 0.0000101605d },
            { 36000.0d, 0.0000107509d },
            { 37000.0d, 0.0000113501d },
            { 38000.0d, 0.0000119604d },
            { 39000.0d, 0.0000125818d },
            { 40000.0d, 0.0000132139d },
            { 41000.0d, 0.0000138535d },
            { 42000.0d, 0.0000145026d },
            { 43000.0d, 0.0000151607d },
            { 44000.0d, 0.000015828d },
            { 45000.0d, 0.0000165016d },
            { 46000.0d, 0.0000171829d },
            { 47000.0d, 0.0000178719d },
            { 48000.0d, 0.0000185687d },
            { 49000.0d, 0.0000192703d },
            { 50000.0d, 0.0000199785d },
            { 51000.0d, 0.0000206932d },
            { 52000.0d, 0.0000214141d },
            { 53000.0d, 0.0000221392d },
            { 54000.0d, 0.0000228696d },
            { 55000.0d, 0.0000236052d },
            { 56000.0d, 0.000024346d },
            { 57000.0d, 0.0000250902d },
            { 58000.0d, 0.0000258385d },
            { 59000.0d, 0.0000265911d },
            { 60000.0d, 0.0000273481d },
            { 61000.0d, 0.0000281075d },
            { 62000.0d, 0.0000288703d },
            { 63000.0d, 0.0000296367d },
            { 64000.0d, 0.0000304064d },
            { 65000.0d, 0.000031178d },
            { 66000.0d, 0.0000319523d },
            { 67000.0d, 0.0000327293d },
            { 68000.0d, 0.000033509d },
            { 69000.0d, 0.0000342901d },
            { 70000.0d, 0.0000350731d },
            { 71000.0d, 0.0000358583d },
            { 72000.0d, 0.0000366456d },
            { 73000.0d, 0.0000374337d },
            { 74000.0d, 0.0000382233d },
            { 75000.0d, 0.0000390145d },
            { 76000.0d, 0.0000398072d },
            { 77000.0d, 0.0000406004d },
            { 78000.0d, 0.0000413946d },
            { 79000.0d, 0.0000421899d },
            { 80000.0d, 0.0000429862d },
            { 81000.0d, 0.0000437827d },
            { 82000.0d, 0.0000445798d },
            { 83000.0d, 0.0000453776d },
            { 84000.0d, 0.0000461761d },
            { 85000.0d, 0.0000469744d },
            { 86000.0d, 0.000047773d },
            { 87000.0d, 0.000048572d },
            { 88000.0d, 0.0000493713d },
            { 89000.0d, 0.0000501701d },
            { 90000.0d, 0.000050969d },
            { 91000.0d, 0.0000517679d },
            { 92000.0d, 0.0000525669d },
            { 93000.0d, 0.0000533652d },
            { 94000.0d, 0.0000541633d },
            { 95000.0d, 0.0000549612d },
            { 96000.0d, 0.0000557589d },
            { 97000.0d, 0.0000565557d },
            { 98000.0d, 0.0000573521d },
            { 99000.0d, 0.0000581481d },
            { 100000.0d, 0.0000589437d },
            { 104000.0d, 0.0000621185d },
            { 108000.0d, 0.0000652807d },
            { 112000.0d, 0.0000684277d },
            { 116000.0d, 0.0000715532d },
            { 120000.0d, 0.0000746542d },
            { 124000.0d, 0.0000777288d },
            { 128000.0d, 0.0000807752d },
            { 132000.0d, 0.0000837917d },
            { 136000.0d, 0.0000867768d },
            { 140000.0d, 0.0000897294d },
            { 144000.0d, 0.0000926484d },
            { 148000.0d, 0.0000955327d },
            { 152000.0d, 0.0000983816d },
            { 156000.0d, 0.000101194d },
            { 160000.0d, 0.00010397d },
            { 164000.0d, 0.000106708d },
            { 168000.0d, 0.000109408d },
            { 172000.0d, 0.00011207d },
            { 176000.0d, 0.000114693d },
            { 180000.0d, 0.000117277d },
            { 184000.0d, 0.000119821d },
            { 188000.0d, 0.000122326d },
            { 192000.0d, 0.000124791d },
            { 196000.0d, 0.000127216d },
            { 200000.0d, 0.000129601d },
            { 204000.0d, 0.000131945d },
            { 208000.0d, 0.00013425d },
            { 212000.0d, 0.000136514d },
            { 216000.0d, 0.000138738d },
            { 220000.0d, 0.000140921d },
            { 224000.0d, 0.000143064d },
            { 228000.0d, 0.000145167d },
            { 232000.0d, 0.000147231d },
            { 236000.0d, 0.000149254d },
            { 240000.0d, 0.000151237d },
            { 244000.0d, 0.000153181d },
            { 248000.0d, 0.000155084d },
            { 252000.0d, 0.000156949d },
            { 256000.0d, 0.000158774d },
            { 260000.0d, 0.000160561d },
            { 264000.0d, 0.000162308d },
            { 268000.0d, 0.000164017d },
            { 272000.0d, 0.000165686d },
            { 276000.0d, 0.000167318d },
            { 280000.0d, 0.000168912d },
            { 284000.0d, 0.000170467d },
            { 288000.0d, 0.000171985d },
            { 292000.0d, 0.000173465d },
            { 296000.0d, 0.000174909d },
            { 300000.0d, 0.000176316d },
            { 304000.0d, 0.000177686d },
            { 308000.0d, 0.000179019d },
            { 312000.0d, 0.000180317d },
            { 316000.0d, 0.00018158d },
            { 320000.0d, 0.000182806d },
            { 324000.0d, 0.000183998d },
            { 328000.0d, 0.000185155d },
            { 332000.0d, 0.000186277d },
            { 336000.0d, 0.000187365d },
            { 340000.0d, 0.000188419d },
            { 344000.0d, 0.00018944d },
            { 348000.0d, 0.000190427d },
            { 352000.0d, 0.000191382d },
            { 356000.0d, 0.000192305d },
            { 360000.0d, 0.000193194d },
            { 364000.0d, 0.000194053d },
            { 368000.0d, 0.000194877d },
            { 372000.0d, 0.000195666d },
            { 376000.0d, 0.000196418d },
            { 380000.0d, 0.000197134d },
            { 384000.0d, 0.000197815d },
            { 388000.0d, 0.000198459d },
            { 392000.0d, 0.000199069d },
            { 396000.0d, 0.000199643d },
            { 400000.0d, 0.000200183d },
            { 404000.0d, 0.000200687d },
            { 408000.0d, 0.000201156d },
            { 412000.0d, 0.000201592d },
            { 416000.0d, 0.000201992d },
            { 420000.0d, 0.000202359d },
            { 424000.0d, 0.000202692d },
            { 428000.0d, 0.000202992d },
            { 432000.0d, 0.000203257d },
            { 436000.0d, 0.000203489d },
            { 440000.0d, 0.000203688d },
            { 444000.0d, 0.000203855d },
            { 448000.0d, 0.000203989d },
            { 452000.0d, 0.000204091d },
            { 456000.0d, 0.000204159d },
            { 460000.0d, 0.000204196d },
            { 464000.0d, 0.000204202d },
            { 468000.0d, 0.000204174d },
            { 472000.0d, 0.000204115d },
            { 476000.0d, 0.000204024d },
            { 480000.0d, 0.000203901d },
            { 484000.0d, 0.000203746d },
            { 488000.0d, 0.000203562d },
            { 492000.0d, 0.000203346d },
            { 496000.0d, 0.000203099d },
            { 500000.0d, 0.000202822d },
            { 504000.0d, 0.000202514d },
            { 508000.0d, 0.000202177d },
            { 512000.0d, 0.000201811d },
            { 516000.0d, 0.000201414d },
            { 520000.0d, 0.000200989d },
            { 524000.0d, 0.000200534d },
            { 528000.0d, 0.000200051d },
            { 532000.0d, 0.00019954d },
            { 536000.0d, 0.000199d },
            { 540000.0d, 0.000198433d },
            { 544000.0d, 0.000197838d },
            { 548000.0d, 0.000197216d },
            { 552000.0d, 0.000196566d },
            { 556000.0d, 0.00019589d },
            { 560000.0d, 0.000195188d },
            { 564000.0d, 0.000194459d },
            { 568000.0d, 0.000193705d },
            { 572000.0d, 0.000192926d },
            { 576000.0d, 0.00019212d },
            { 580000.0d, 0.000191289d },
            { 584000.0d, 0.000190435d },
            { 588000.0d, 0.000189556d },
            { 592000.0d, 0.000188652d },
            { 596000.0d, 0.000187726d },
            { 600000.0d, 0.000186775d },
            { 604000.0d, 0.000185802d },
            { 608000.0d, 0.000184806d },
            { 612000.0d, 0.000183787d },
            { 616000.0d, 0.000182746d },
            { 620000.0d, 0.000181685d },
            { 624000.0d, 0.000180601d },
            { 628000.0d, 0.000179496d },
            { 632000.0d, 0.00017837d },
            { 636000.0d, 0.000177224d },
            { 640000.0d, 0.000176059d },
            { 644000.0d, 0.000174873d },
            { 648000.0d, 0.000173668d },
            { 652000.0d, 0.000172444d },
            { 656000.0d, 0.000171202d },
            { 660000.0d, 0.000169941d },
            { 664000.0d, 0.000168663d },
            { 668000.0d, 0.000167367d },
            { 672000.0d, 0.000166054d },
            { 676000.0d, 0.000164724d },
            { 680000.0d, 0.000163378d },
            { 684000.0d, 0.000162016d },
            { 688000.0d, 0.000160638d },
            { 692000.0d, 0.000159246d },
            { 696000.0d, 0.000157838d },
            { 700000.0d, 0.000156417d },
            { 704000.0d, 0.000154981d },
            { 708000.0d, 0.000153532d },
            { 712000.0d, 0.000152068d },
            { 716000.0d, 0.000150594d },
            { 720000.0d, 0.000149106d },
            { 724000.0d, 0.000147607d },
            { 728000.0d, 0.000146096d },
            { 732000.0d, 0.000144574d },
            { 736000.0d, 0.000143042d },
            { 740000.0d, 0.000141499d },
            { 744000.0d, 0.000139946d },
            { 748000.0d, 0.000138385d },
            { 752000.0d, 0.000136815d },
            { 756000.0d, 0.000135235d },
            { 760000.0d, 0.000133649d },
            { 764000.0d, 0.000132054d },
            { 768000.0d, 0.000130453d },
            { 772000.0d, 0.000128845d },
            { 776000.0d, 0.00012723d },
            { 780000.0d, 0.00012561d },
            { 784000.0d, 0.000123986d },
            { 788000.0d, 0.000122356d },
            { 792000.0d, 0.000120721d },
            { 796000.0d, 0.000119084d },
            { 800000.0d, 0.000117443d },
            { 804000.0d, 0.000115799d },
            { 808000.0d, 0.000114152d },
            { 812000.0d, 0.000112504d },
            { 816000.0d, 0.000110855d },
            { 820000.0d, 0.000109205d },
            { 824000.0d, 0.000107554d },
            { 828000.0d, 0.000105904d },
            { 832000.0d, 0.000104253d },
            { 836000.0d, 0.000102605d },
            { 840000.0d, 0.000100958d },
            { 844000.0d, 0.0000993133d },
            { 848000.0d, 0.0000976713d },
            { 852000.0d, 0.0000960324d },
            { 856000.0d, 0.0000943973d },
            { 860000.0d, 0.0000927665d },
            { 864000.0d, 0.0000911406d },
            { 868000.0d, 0.0000895199d },
            { 872000.0d, 0.0000879053d },
            { 876000.0d, 0.0000862969d },
            { 880000.0d, 0.0000846956d },
            { 884000.0d, 0.0000831018d },
            { 888000.0d, 0.0000815161d },
            { 892000.0d, 0.0000799389d },
            { 896000.0d, 0.000078371d },
            { 900000.0d, 0.0000768128d },
            { 904000.0d, 0.0000752648d },
            { 908000.0d, 0.0000737277d },
            { 912000.0d, 0.000072202d },
            { 916000.0d, 0.0000706882d },
            { 920000.0d, 0.0000691825d },
            { 924000.0d, 0.0000676808d },
            { 928000.0d, 0.0000661837d },
            { 932000.0d, 0.0000646916d },
            { 936000.0d, 0.0000632048d },
            { 940000.0d, 0.0000617238d },
            { 944000.0d, 0.0000602491d },
            { 948000.0d, 0.000058781d },
            { 952000.0d, 0.0000573199d },
            { 956000.0d, 0.0000558664d },
            { 960000.0d, 0.0000544208d },
            { 964000.0d, 0.0000529836d },
            { 968000.0d, 0.0000515552d },
            { 972000.0d, 0.0000501361d },
            { 976000.0d, 0.0000487267d },
            { 980000.0d, 0.0000473275d },
            { 984000.0d, 0.0000459388d },
            { 988000.0d, 0.0000445613d },
            { 992000.0d, 0.0000431952d },
            { 996000.0d, 0.0000418411d },
            { 1000000.0d, 0.0000404995d },
            { 1004000.0d, 0.0000391707d },
            { 1008000.0d, 0.0000378553d },
            { 1012000.0d, 0.0000365537d },
            { 1016000.0d, 0.0000352664d },
            { 1020000.0d, 0.0000339939d },
            { 1024000.0d, 0.0000327366d },
            { 1028000.0d, 0.000031495d },
            { 1032000.0d, 0.0000302696d },
            { 1036000.0d, 0.0000290608d },
            { 1040000.0d, 0.0000278692d },
            { 1044000.0d, 0.0000266953d },
            { 1048000.0d, 0.0000255394d },
            { 1052000.0d, 0.0000244022d },
            { 1056000.0d, 0.000023284d },
            { 1060000.0d, 0.0000221854d },
            { 1064000.0d, 0.000021107d },
            { 1068000.0d, 0.0000200491d },
            { 1072000.0d, 0.0000190122d },
            { 1076000.0d, 0.000017997d },
            { 1080000.0d, 0.0000170038d },
            { 1084000.0d, 0.0000160333d },
            { 1088000.0d, 0.0000150858d },
            { 1092000.0d, 0.000014162d },
            { 1096000.0d, 0.0000132622d },
            { 1100000.0d, 0.0000123872d },
            { 1104000.0d, 0.0000115372d },
            { 1108000.0d, 0.000010713d },
            { 1112000.0d, 0.00000991489d },
            { 1116000.0d, 0.00000914354d },
            { 1120000.0d, 0.00000839943d },
            { 1124000.0d, 0.00000768309d },
            { 1128000.0d, 0.00000699504d },
            { 1132000.0d, 0.00000633582d },
            { 1136000.0d, 0.00000570596d },
            { 1140000.0d, 0.00000510598d },
            { 1144000.0d, 0.00000453643d },
            { 1148000.0d, 0.00000399784d },
            { 1152000.0d, 0.00000349075d },
            { 1156000.0d, 0.0000030157d },
            { 1160000.0d, 0.00000257323d },
            { 1164000.0d, 0.00000216388d },
            { 1168000.0d, 0.0000017882d },
            { 1172000.0d, 0.00000144671d },
            { 1176000.0d, 0.00000113998d },
            { 1180000.0d, 0.000000868535d },
            { 1184000.0d, 0.000000632921d },
            { 1188000.0d, 0.000000433677d },
            { 1192000.0d, 0.000000271336d },
            { 1196000.0d, 0.000000146426d },
            { 1200000.0d, 0.0000000594623d },
            { 1204000.0d, 0.0000000109316d },
            { 1207000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    