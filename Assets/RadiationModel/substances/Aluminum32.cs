using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Aluminum32 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum32";
        public override double halfLife { get; } = 0.033d;
        public override double atomicWeight { get; } = 31.98808d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silicon32()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.12d, new GammaParticle(1941400.0, 0.00064)), new(0.0132d, new GammaParticle(2289400.0, 0.00054)), new(0.0432d, new GammaParticle(3042300.0, 0.00041)), new(0.0168d, new GammaParticle(3844000.0, 0.00032)), new(0.0168d, new GammaParticle(4230000.0, 0.00029)), new(1.018280175e-09d, new GammaParticle(118.0, 10.50714)), new(3.066981717206401e-08d, new GammaParticle(1740.0, 0.71255)), new(1.5448386909568643e-08d, new GammaParticle(1740.0, 0.71255)), new(1.3374279183673471e-09d, new GammaParticle(1836.0, 0.6753)), new(1.3374279183673471e-09d, new GammaParticle(1836.0, 0.6753)) } },
            { 0.006999999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silicon32()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.12d, new GammaParticle(1941400.0, 0.00064)), new(0.0132d, new GammaParticle(2289400.0, 0.00054)), new(0.0432d, new GammaParticle(3042300.0, 0.00041)), new(0.0168d, new GammaParticle(3844000.0, 0.00032)), new(0.0168d, new GammaParticle(4230000.0, 0.00029)), new(1.018280175e-09d, new GammaParticle(118.0, 10.50714)), new(3.066981717206401e-08d, new GammaParticle(1740.0, 0.71255)), new(1.5448386909568643e-08d, new GammaParticle(1740.0, 0.71255)), new(1.3374279183673471e-09d, new GammaParticle(1836.0, 0.6753)), new(1.3374279183673471e-09d, new GammaParticle(1836.0, 0.6753)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00000227921d },
            { 12000.0d, 0.00000257211d },
            { 24000.0d, 0.00000286239d },
            { 36000.0d, 0.00000315007d },
            { 48000.0d, 0.00000343448d },
            { 60000.0d, 0.00000371582d },
            { 72000.0d, 0.00000399436d },
            { 84000.0d, 0.00000427072d },
            { 96000.0d, 0.00000454548d },
            { 108000.0d, 0.00000481881d },
            { 120000.0d, 0.00000509125d },
            { 132000.0d, 0.0000053635d },
            { 144000.0d, 0.00000563795d },
            { 156000.0d, 0.00000591329d },
            { 168000.0d, 0.00000618956d },
            { 180000.0d, 0.00000646762d },
            { 192000.0d, 0.00000674769d },
            { 204000.0d, 0.00000702943d },
            { 216000.0d, 0.00000731293d },
            { 228000.0d, 0.00000759883d },
            { 240000.0d, 0.00000788676d },
            { 252000.0d, 0.00000817675d },
            { 264000.0d, 0.00000846897d },
            { 276000.0d, 0.00000876351d },
            { 288000.0d, 0.00000906026d },
            { 300000.0d, 0.00000935924d },
            { 312000.0d, 0.00000966058d },
            { 324000.0d, 0.00000996421d },
            { 336000.0d, 0.0000102701d },
            { 348000.0d, 0.0000105784d },
            { 360000.0d, 0.0000108889d },
            { 372000.0d, 0.0000112017d },
            { 384000.0d, 0.0000115168d },
            { 396000.0d, 0.0000118342d },
            { 408000.0d, 0.0000121538d },
            { 420000.0d, 0.0000124757d },
            { 432000.0d, 0.0000127998d },
            { 444000.0d, 0.0000131261d },
            { 456000.0d, 0.0000134546d },
            { 468000.0d, 0.0000137852d },
            { 480000.0d, 0.0000141181d },
            { 492000.0d, 0.000014453d },
            { 504000.0d, 0.0000147901d },
            { 516000.0d, 0.0000151293d },
            { 528000.0d, 0.0000154705d },
            { 540000.0d, 0.0000158137d },
            { 552000.0d, 0.000016159d },
            { 564000.0d, 0.0000165063d },
            { 576000.0d, 0.0000168555d },
            { 588000.0d, 0.0000172067d },
            { 600000.0d, 0.0000175599d },
            { 612000.0d, 0.0000179149d },
            { 624000.0d, 0.0000182717d },
            { 636000.0d, 0.0000186305d },
            { 648000.0d, 0.000018991d },
            { 660000.0d, 0.0000193534d },
            { 672000.0d, 0.0000197175d },
            { 684000.0d, 0.0000200833d },
            { 696000.0d, 0.0000204509d },
            { 708000.0d, 0.0000208202d },
            { 720000.0d, 0.0000211911d },
            { 732000.0d, 0.0000215637d },
            { 744000.0d, 0.0000219379d },
            { 756000.0d, 0.0000223136d },
            { 768000.0d, 0.000022691d },
            { 780000.0d, 0.0000230699d },
            { 792000.0d, 0.0000234502d },
            { 804000.0d, 0.000023832d },
            { 816000.0d, 0.0000242154d },
            { 828000.0d, 0.0000246001d },
            { 840000.0d, 0.0000249862d },
            { 852000.0d, 0.0000253737d },
            { 864000.0d, 0.0000257625d },
            { 876000.0d, 0.0000261527d },
            { 888000.0d, 0.0000265442d },
            { 900000.0d, 0.000026937d },
            { 912000.0d, 0.000027331d },
            { 924000.0d, 0.0000277263d },
            { 936000.0d, 0.0000281227d },
            { 948000.0d, 0.0000285204d },
            { 960000.0d, 0.0000289192d },
            { 972000.0d, 0.0000293191d },
            { 984000.0d, 0.0000297201d },
            { 996000.0d, 0.0000301222d },
            { 1008000.0d, 0.0000305253d },
            { 1051000.0d, 0.0000319781d },
            { 1094000.0d, 0.0000334431d },
            { 1137000.0d, 0.000034919d },
            { 1180000.0d, 0.0000364048d },
            { 1223000.0d, 0.0000378996d },
            { 1266000.0d, 0.0000394021d },
            { 1309000.0d, 0.0000409115d },
            { 1352000.0d, 0.0000424267d },
            { 1395000.0d, 0.0000439469d },
            { 1438000.0d, 0.000045471d },
            { 1481000.0d, 0.0000469981d },
            { 1524000.0d, 0.0000485274d },
            { 1567000.0d, 0.000050058d },
            { 1610000.0d, 0.000051589d },
            { 1653000.0d, 0.0000531196d },
            { 1696000.0d, 0.0000546491d },
            { 1739000.0d, 0.0000561766d },
            { 1782000.0d, 0.0000577013d },
            { 1825000.0d, 0.0000592226d },
            { 1868000.0d, 0.0000607398d },
            { 1911000.0d, 0.0000622523d },
            { 1954000.0d, 0.0000637592d },
            { 1997000.0d, 0.00006526d },
            { 2040000.0d, 0.0000667541d },
            { 2083000.0d, 0.0000682409d },
            { 2126000.0d, 0.0000697198d },
            { 2169000.0d, 0.0000711903d },
            { 2212000.0d, 0.0000726519d },
            { 2255000.0d, 0.0000741041d },
            { 2298000.0d, 0.0000755464d },
            { 2341000.0d, 0.0000769784d },
            { 2384000.0d, 0.0000783997d },
            { 2427000.0d, 0.0000798098d },
            { 2470000.0d, 0.0000812083d },
            { 2513000.0d, 0.000082595d },
            { 2556000.0d, 0.0000839695d },
            { 2599000.0d, 0.0000853315d },
            { 2642000.0d, 0.0000866806d },
            { 2685000.0d, 0.0000880168d },
            { 2728000.0d, 0.0000893396d },
            { 2771000.0d, 0.0000906489d },
            { 2814000.0d, 0.0000919445d },
            { 2857000.0d, 0.0000932263d },
            { 2900000.0d, 0.000094494d },
            { 2943000.0d, 0.0000957475d },
            { 2986000.0d, 0.0000969868d },
            { 3029000.0d, 0.0000982118d },
            { 3072000.0d, 0.0000994224d },
            { 3115000.0d, 0.000100618d },
            { 3158000.0d, 0.0001018d },
            { 3201000.0d, 0.000102967d },
            { 3244000.0d, 0.00010412d },
            { 3287000.0d, 0.000105259d },
            { 3330000.0d, 0.000106383d },
            { 3373000.0d, 0.000107493d },
            { 3416000.0d, 0.000108589d },
            { 3459000.0d, 0.000109671d },
            { 3502000.0d, 0.000110739d },
            { 3545000.0d, 0.000111794d },
            { 3588000.0d, 0.000112835d },
            { 3631000.0d, 0.000113863d },
            { 3674000.0d, 0.000114879d },
            { 3717000.0d, 0.000115881d },
            { 3760000.0d, 0.000116871d },
            { 3803000.0d, 0.000117847d },
            { 3846000.0d, 0.000118801d },
            { 3889000.0d, 0.000119734d },
            { 3932000.0d, 0.000120643d },
            { 3975000.0d, 0.00012153d },
            { 4018000.0d, 0.000122394d },
            { 4061000.0d, 0.000123235d },
            { 4104000.0d, 0.000124052d },
            { 4147000.0d, 0.000124846d },
            { 4190000.0d, 0.000125616d },
            { 4233000.0d, 0.000126362d },
            { 4276000.0d, 0.000127083d },
            { 4319000.0d, 0.000127781d },
            { 4362000.0d, 0.000128455d },
            { 4405000.0d, 0.000129104d },
            { 4448000.0d, 0.000129728d },
            { 4491000.0d, 0.000130328d },
            { 4534000.0d, 0.000130903d },
            { 4577000.0d, 0.000131453d },
            { 4620000.0d, 0.000131978d },
            { 4663000.0d, 0.000132478d },
            { 4706000.0d, 0.000132954d },
            { 4749000.0d, 0.000133403d },
            { 4792000.0d, 0.000133829d },
            { 4835000.0d, 0.000134228d },
            { 4878000.0d, 0.000134604d },
            { 4921000.0d, 0.000134953d },
            { 4964000.0d, 0.000135278d },
            { 5007000.0d, 0.000135578d },
            { 5050000.0d, 0.000135853d },
            { 5093000.0d, 0.000136103d },
            { 5136000.0d, 0.000136328d },
            { 5179000.0d, 0.000136527d },
            { 5222000.0d, 0.000136703d },
            { 5265000.0d, 0.000136854d },
            { 5308000.0d, 0.00013698d },
            { 5351000.0d, 0.000137082d },
            { 5394000.0d, 0.000137159d },
            { 5437000.0d, 0.000137212d },
            { 5480000.0d, 0.000137242d },
            { 5523000.0d, 0.000137246d },
            { 5566000.0d, 0.000137228d },
            { 5609000.0d, 0.000137186d },
            { 5652000.0d, 0.00013712d },
            { 5695000.0d, 0.000137031d },
            { 5738000.0d, 0.000136919d },
            { 5781000.0d, 0.000136785d },
            { 5824000.0d, 0.000136627d },
            { 5867000.0d, 0.000136447d },
            { 5910000.0d, 0.000136245d },
            { 5953000.0d, 0.000136022d },
            { 5996000.0d, 0.000135776d },
            { 6039000.0d, 0.000135509d },
            { 6082000.0d, 0.000135221d },
            { 6125000.0d, 0.000134912d },
            { 6168000.0d, 0.000134583d },
            { 6211000.0d, 0.000134234d },
            { 6254000.0d, 0.000133864d },
            { 6297000.0d, 0.000133475d },
            { 6340000.0d, 0.000133067d },
            { 6383000.0d, 0.00013264d },
            { 6426000.0d, 0.000132194d },
            { 6469000.0d, 0.00013173d },
            { 6512000.0d, 0.000131248d },
            { 6555000.0d, 0.000130749d },
            { 6598000.0d, 0.000130233d },
            { 6641000.0d, 0.0001297d },
            { 6684000.0d, 0.000129151d },
            { 6727000.0d, 0.000128586d },
            { 6770000.0d, 0.000128006d },
            { 6813000.0d, 0.000127411d },
            { 6856000.0d, 0.000126801d },
            { 6899000.0d, 0.000126177d },
            { 6942000.0d, 0.000125539d },
            { 6985000.0d, 0.000124889d },
            { 7028000.0d, 0.000124226d },
            { 7071000.0d, 0.000123551d },
            { 7114000.0d, 0.000122863d },
            { 7157000.0d, 0.000122165d },
            { 7200000.0d, 0.000121456d },
            { 7243000.0d, 0.000120735d },
            { 7286000.0d, 0.000119999d },
            { 7329000.0d, 0.00011925d },
            { 7372000.0d, 0.000118488d },
            { 7415000.0d, 0.000117715d },
            { 7458000.0d, 0.000116928d },
            { 7501000.0d, 0.00011613d },
            { 7544000.0d, 0.000115322d },
            { 7587000.0d, 0.000114503d },
            { 7630000.0d, 0.000113674d },
            { 7673000.0d, 0.000112834d },
            { 7716000.0d, 0.000111985d },
            { 7759000.0d, 0.000111128d },
            { 7802000.0d, 0.000110264d },
            { 7845000.0d, 0.00010939d },
            { 7888000.0d, 0.00010851d },
            { 7931000.0d, 0.000107623d },
            { 7974000.0d, 0.00010673d },
            { 8017000.0d, 0.00010583d },
            { 8060000.0d, 0.000104918d },
            { 8103000.0d, 0.000103994d },
            { 8146000.0d, 0.000103058d },
            { 8189000.0d, 0.00010211d },
            { 8232000.0d, 0.000101151d },
            { 8275000.0d, 0.000100182d },
            { 8318000.0d, 0.0000992015d },
            { 8361000.0d, 0.0000982111d },
            { 8404000.0d, 0.0000972109d },
            { 8447000.0d, 0.0000962013d },
            { 8490000.0d, 0.0000951828d },
            { 8533000.0d, 0.0000941557d },
            { 8576000.0d, 0.0000931203d },
            { 8619000.0d, 0.0000920772d },
            { 8662000.0d, 0.0000910266d },
            { 8705000.0d, 0.000089969d },
            { 8748000.0d, 0.0000889048d },
            { 8791000.0d, 0.0000878323d },
            { 8834000.0d, 0.00008675d },
            { 8877000.0d, 0.0000856582d },
            { 8920000.0d, 0.0000845573d },
            { 8963000.0d, 0.0000834476d },
            { 9006000.0d, 0.0000823295d },
            { 9049000.0d, 0.0000812032d },
            { 9092000.0d, 0.0000800692d },
            { 9135000.0d, 0.0000789279d },
            { 9178000.0d, 0.0000777796d },
            { 9221000.0d, 0.0000766246d },
            { 9264000.0d, 0.0000754634d },
            { 9307000.0d, 0.0000742963d },
            { 9350000.0d, 0.0000731237d },
            { 9393000.0d, 0.000071946d },
            { 9436000.0d, 0.0000707636d },
            { 9479000.0d, 0.0000695769d },
            { 9522000.0d, 0.0000683863d },
            { 9565000.0d, 0.0000671922d },
            { 9608000.0d, 0.000065995d },
            { 9651000.0d, 0.0000647952d },
            { 9694000.0d, 0.0000635931d },
            { 9737000.0d, 0.0000623892d },
            { 9780000.0d, 0.0000611839d },
            { 9823000.0d, 0.0000599777d },
            { 9866000.0d, 0.0000587709d },
            { 9909000.0d, 0.0000575641d },
            { 9952000.0d, 0.0000563577d },
            { 9995000.0d, 0.0000551521d },
            { 10038000.0d, 0.0000539479d },
            { 10081000.0d, 0.0000527454d },
            { 10124000.0d, 0.0000515451d },
            { 10167000.0d, 0.0000503475d },
            { 10210000.0d, 0.0000491532d },
            { 10253000.0d, 0.0000479624d },
            { 10296000.0d, 0.0000467758d },
            { 10339000.0d, 0.0000455939d },
            { 10382000.0d, 0.0000444171d },
            { 10425000.0d, 0.0000432458d },
            { 10468000.0d, 0.0000420808d },
            { 10511000.0d, 0.0000409223d },
            { 10554000.0d, 0.0000397711d },
            { 10597000.0d, 0.0000386275d },
            { 10640000.0d, 0.000037492d },
            { 10683000.0d, 0.0000363653d },
            { 10726000.0d, 0.0000352477d },
            { 10769000.0d, 0.00003414d },
            { 10812000.0d, 0.0000330425d },
            { 10855000.0d, 0.0000319558d },
            { 10898000.0d, 0.0000308805d },
            { 10941000.0d, 0.0000298171d },
            { 10984000.0d, 0.0000287661d },
            { 11027000.0d, 0.000027728d },
            { 11070000.0d, 0.0000267026d },
            { 11113000.0d, 0.0000256881d },
            { 11156000.0d, 0.000024685d },
            { 11199000.0d, 0.0000236939d },
            { 11242000.0d, 0.0000227152d },
            { 11285000.0d, 0.0000217494d },
            { 11328000.0d, 0.000020797d },
            { 11371000.0d, 0.0000198587d },
            { 11414000.0d, 0.0000189349d },
            { 11457000.0d, 0.000018026d },
            { 11500000.0d, 0.0000171327d },
            { 11543000.0d, 0.0000162556d },
            { 11586000.0d, 0.000015395d },
            { 11629000.0d, 0.0000145516d },
            { 11672000.0d, 0.0000137259d },
            { 11715000.0d, 0.0000129185d },
            { 11758000.0d, 0.0000121299d },
            { 11801000.0d, 0.0000113607d },
            { 11844000.0d, 0.0000106113d },
            { 11887000.0d, 0.00000988257d },
            { 11930000.0d, 0.00000917483d },
            { 11973000.0d, 0.00000848868d },
            { 12016000.0d, 0.00000782472d },
            { 12059000.0d, 0.00000718352d },
            { 12102000.0d, 0.00000656564d },
            { 12145000.0d, 0.00000597168d },
            { 12188000.0d, 0.0000054022d },
            { 12231000.0d, 0.00000485779d },
            { 12274000.0d, 0.00000433902d },
            { 12317000.0d, 0.0000038465d },
            { 12360000.0d, 0.00000338078d },
            { 12403000.0d, 0.00000294247d },
            { 12446000.0d, 0.00000253215d },
            { 12489000.0d, 0.00000215042d },
            { 12532000.0d, 0.00000179785d },
            { 12575000.0d, 0.00000147503d },
            { 12618000.0d, 0.00000118256d },
            { 12661000.0d, 0.000000920991d },
            { 12704000.0d, 0.000000690928d },
            { 12747000.0d, 0.000000492922d },
            { 12790000.0d, 0.000000327533d },
            { 12833000.0d, 0.000000195303d },
            { 12876000.0d, 0.0000000967433d },
            { 12919000.0d, 0.0000000323105d },
            { 12962000.0d, 0.00000000233316d },
            { 12978000.0d, 0d },

        }; 
    }
}
    