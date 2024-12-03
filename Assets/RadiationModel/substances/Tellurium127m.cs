using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium127m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium127m";
        public override double halfLife { get; } = 9167040.0d;
        public override double atomicWeight { get; } = 126.90532d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.976d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium127()), new(0.00084d, new GammaParticle(88260.0, 0.01405)), new(0.069490950624d, new GammaParticle(4135.0, 0.29984)), new(0.10132816049696912d, new GammaParticle(27202.0, 0.04558)), new(0.18869303630720505d, new GammaParticle(27473.0, 0.04513)), new(0.054000659980136284d, new GammaParticle(31093.0, 0.03988)), new(0.06571880319582586d, new GammaParticle(31359.0, 0.03954)), new(0.011718143215689576d, new GammaParticle(31698.0, 0.03911)) } },
            { 0.024d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine127()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.0050880000000000005d, new GammaParticle(57630.0, 0.02151)), new(2.304e-05d, new GammaParticle(593300.0, 0.00209)), new(8.64e-07d, new GammaParticle(628600.0, 0.00197)), new(2.88e-06d, new GammaParticle(651000.0, 0.0019)), new(0.0001248d, new GammaParticle(658900.0, 0.00188)), new(0.0015547654454900737d, new GammaParticle(4335.0, 0.28601)), new(0.004036252184138081d, new GammaParticle(28318.0, 0.04378)), new(0.0074967536852490356d, new GammaParticle(28613.0, 0.04333)), new(0.002159851670156021d, new GammaParticle(32395.0, 0.03827)), new(0.0026479781476112818d, new GammaParticle(32680.0, 0.03794)), new(0.00048812647745526073d, new GammaParticle(33040.0, 0.03753)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00262923d },
            { 200.0d, 0.00256749d },
            { 400.0d, 0.00253041d },
            { 600.0d, 0.00251799d },
            { 800.0d, 0.00251241d },
            { 1000.0d, 0.00250967d },
            { 1500.0d, 0.00250738d },
            { 2000.0d, 0.00250677d },
            { 2500.0d, 0.00250639d },
            { 3000.0d, 0.0025059d },
            { 3500.0d, 0.00250519d },
            { 4000.0d, 0.00250423d },
            { 4500.0d, 0.002503d },
            { 5000.0d, 0.00250151d },
            { 5500.0d, 0.00249977d },
            { 6000.0d, 0.00249777d },
            { 6500.0d, 0.00249571d },
            { 7000.0d, 0.00249346d },
            { 7500.0d, 0.00249104d },
            { 8000.0d, 0.00248845d },
            { 8500.0d, 0.00248594d },
            { 9000.0d, 0.00248337d },
            { 9500.0d, 0.00248073d },
            { 10000.0d, 0.00247801d },
            { 11000.0d, 0.00247262d },
            { 12000.0d, 0.00246711d },
            { 13000.0d, 0.00246158d },
            { 14000.0d, 0.00245599d },
            { 15000.0d, 0.0024504d },
            { 16000.0d, 0.0024448d },
            { 17000.0d, 0.0024392d },
            { 18000.0d, 0.0024336d },
            { 19000.0d, 0.00242801d },
            { 20000.0d, 0.00242244d },
            { 21000.0d, 0.00241689d },
            { 22000.0d, 0.00241138d },
            { 23000.0d, 0.00240589d },
            { 24000.0d, 0.00240043d },
            { 25000.0d, 0.00239501d },
            { 26000.0d, 0.00238963d },
            { 27000.0d, 0.00238429d },
            { 28000.0d, 0.00237899d },
            { 29000.0d, 0.00237375d },
            { 30000.0d, 0.00236855d },
            { 31000.0d, 0.00236341d },
            { 32000.0d, 0.00235831d },
            { 33000.0d, 0.00235327d },
            { 34000.0d, 0.00234829d },
            { 35000.0d, 0.00234337d },
            { 36000.0d, 0.0023385d },
            { 37000.0d, 0.0023337d },
            { 38000.0d, 0.00232896d },
            { 39000.0d, 0.00232428d },
            { 40000.0d, 0.00231966d },
            { 41000.0d, 0.00231511d },
            { 42000.0d, 0.00231063d },
            { 43000.0d, 0.00230622d },
            { 44000.0d, 0.00230188d },
            { 45000.0d, 0.00229761d },
            { 46000.0d, 0.00229341d },
            { 47000.0d, 0.00228928d },
            { 48000.0d, 0.00228522d },
            { 49000.0d, 0.00228123d },
            { 50000.0d, 0.00227732d },
            { 51000.0d, 0.00227349d },
            { 52000.0d, 0.00226973d },
            { 53000.0d, 0.00226605d },
            { 54000.0d, 0.00226244d },
            { 55000.0d, 0.00225892d },
            { 56000.0d, 0.00225548d },
            { 57000.0d, 0.00225211d },
            { 58000.0d, 0.00224882d },
            { 59000.0d, 0.00224562d },
            { 60000.0d, 0.0022425d },
            { 61000.0d, 0.00223946d },
            { 62000.0d, 0.0022365d },
            { 63000.0d, 0.00223364d },
            { 64000.0d, 0.00223086d },
            { 65000.0d, 0.00222816d },
            { 66000.0d, 0.00222555d },
            { 67000.0d, 0.00222303d },
            { 68000.0d, 0.00222061d },
            { 69000.0d, 0.00221827d },
            { 70000.0d, 0.00221601d },
            { 71000.0d, 0.00221385d },
            { 72000.0d, 0.00221178d },
            { 73000.0d, 0.0022098d },
            { 74000.0d, 0.00220792d },
            { 75000.0d, 0.00220605d },
            { 76000.0d, 0.00220419d },
            { 77000.0d, 0.00220234d },
            { 78000.0d, 0.00220049d },
            { 79000.0d, 0.00219863d },
            { 80000.0d, 0.00219678d },
            { 81000.0d, 0.00219492d },
            { 82000.0d, 0.00219307d },
            { 83000.0d, 0.00219122d },
            { 84000.0d, 0.00218937d },
            { 85000.0d, 0.00218752d },
            { 86000.0d, 0.00218568d },
            { 87000.0d, 0.00218384d },
            { 88000.0d, 0.002182d },
            { 89000.0d, 0.00218016d },
            { 90000.0d, 0.00217832d },
            { 91000.0d, 0.00217648d },
            { 92000.0d, 0.00217464d },
            { 93000.0d, 0.00217281d },
            { 94000.0d, 0.00217097d },
            { 95000.0d, 0.00216913d },
            { 96000.0d, 0.0021673d },
            { 97000.0d, 0.00216547d },
            { 98000.0d, 0.00216364d },
            { 99000.0d, 0.00216181d },
            { 100000.0d, 0.00215998d },
            { 102000.0d, 0.00215632d },
            { 104000.0d, 0.00215267d },
            { 106000.0d, 0.00214902d },
            { 108000.0d, 0.00214538d },
            { 110000.0d, 0.00214174d },
            { 112000.0d, 0.0021381d },
            { 114000.0d, 0.00213447d },
            { 116000.0d, 0.00213084d },
            { 118000.0d, 0.0021272d },
            { 120000.0d, 0.00212358d },
            { 122000.0d, 0.00211996d },
            { 124000.0d, 0.00211635d },
            { 126000.0d, 0.00211273d },
            { 128000.0d, 0.00210912d },
            { 130000.0d, 0.00210551d },
            { 132000.0d, 0.0021019d },
            { 134000.0d, 0.00209831d },
            { 136000.0d, 0.00209471d },
            { 138000.0d, 0.00209111d },
            { 140000.0d, 0.00208752d },
            { 142000.0d, 0.00208393d },
            { 144000.0d, 0.00208032d },
            { 146000.0d, 0.00207671d },
            { 148000.0d, 0.00207308d },
            { 150000.0d, 0.00206945d },
            { 152000.0d, 0.00206581d },
            { 154000.0d, 0.00206214d },
            { 156000.0d, 0.00205848d },
            { 158000.0d, 0.0020548d },
            { 160000.0d, 0.00205112d },
            { 162000.0d, 0.00204742d },
            { 164000.0d, 0.00204371d },
            { 166000.0d, 0.00203999d },
            { 168000.0d, 0.00203626d },
            { 170000.0d, 0.00203252d },
            { 172000.0d, 0.00202876d },
            { 174000.0d, 0.002025d },
            { 176000.0d, 0.00202121d },
            { 178000.0d, 0.00201742d },
            { 180000.0d, 0.00201362d },
            { 182000.0d, 0.0020098d },
            { 184000.0d, 0.00200597d },
            { 186000.0d, 0.00200212d },
            { 188000.0d, 0.00199826d },
            { 190000.0d, 0.00199439d },
            { 192000.0d, 0.0019905d },
            { 194000.0d, 0.0019866d },
            { 196000.0d, 0.00198269d },
            { 198000.0d, 0.00197876d },
            { 200000.0d, 0.00197481d },
            { 202000.0d, 0.00197085d },
            { 204000.0d, 0.00196688d },
            { 206000.0d, 0.00196289d },
            { 208000.0d, 0.00195888d },
            { 210000.0d, 0.00195486d },
            { 212000.0d, 0.00195082d },
            { 214000.0d, 0.00194676d },
            { 216000.0d, 0.00194269d },
            { 218000.0d, 0.0019386d },
            { 220000.0d, 0.00193449d },
            { 222000.0d, 0.00193037d },
            { 224000.0d, 0.00192622d },
            { 226000.0d, 0.00192206d },
            { 228000.0d, 0.00191788d },
            { 230000.0d, 0.00191368d },
            { 232000.0d, 0.00190946d },
            { 234000.0d, 0.00190522d },
            { 236000.0d, 0.00190097d },
            { 238000.0d, 0.00189669d },
            { 240000.0d, 0.00189239d },
            { 242000.0d, 0.00188807d },
            { 244000.0d, 0.00188373d },
            { 246000.0d, 0.00187936d },
            { 248000.0d, 0.00187498d },
            { 250000.0d, 0.00187057d },
            { 252000.0d, 0.00186614d },
            { 254000.0d, 0.00186168d },
            { 256000.0d, 0.00185721d },
            { 258000.0d, 0.0018527d },
            { 260000.0d, 0.00184818d },
            { 262000.0d, 0.00184363d },
            { 264000.0d, 0.00183905d },
            { 266000.0d, 0.00183445d },
            { 268000.0d, 0.00182982d },
            { 270000.0d, 0.00182517d },
            { 272000.0d, 0.00182049d },
            { 274000.0d, 0.00181578d },
            { 276000.0d, 0.00181104d },
            { 278000.0d, 0.00180628d },
            { 280000.0d, 0.00180148d },
            { 282000.0d, 0.00179666d },
            { 284000.0d, 0.00179181d },
            { 286000.0d, 0.00178693d },
            { 288000.0d, 0.00178202d },
            { 290000.0d, 0.00177708d },
            { 292000.0d, 0.0017721d },
            { 294000.0d, 0.0017671d },
            { 296000.0d, 0.00176206d },
            { 298000.0d, 0.00175699d },
            { 300000.0d, 0.00175189d },
            { 302000.0d, 0.00174675d },
            { 304000.0d, 0.00174158d },
            { 306000.0d, 0.00173637d },
            { 308000.0d, 0.00173113d },
            { 310000.0d, 0.00172586d },
            { 312000.0d, 0.00172055d },
            { 314000.0d, 0.0017152d },
            { 316000.0d, 0.00170981d },
            { 318000.0d, 0.00170439d },
            { 320000.0d, 0.00169893d },
            { 322000.0d, 0.00169344d },
            { 324000.0d, 0.0016879d },
            { 326000.0d, 0.00168232d },
            { 328000.0d, 0.00167671d },
            { 330000.0d, 0.00167105d },
            { 332000.0d, 0.00166536d },
            { 334000.0d, 0.00165962d },
            { 336000.0d, 0.00165384d },
            { 338000.0d, 0.00164802d },
            { 340000.0d, 0.00164216d },
            { 342000.0d, 0.00163626d },
            { 344000.0d, 0.00163031d },
            { 346000.0d, 0.00162432d },
            { 348000.0d, 0.00161828d },
            { 350000.0d, 0.0016122d },
            { 352000.0d, 0.00160607d },
            { 354000.0d, 0.0015999d },
            { 356000.0d, 0.00159369d },
            { 358000.0d, 0.00158742d },
            { 360000.0d, 0.00158111d },
            { 362000.0d, 0.00157476d },
            { 364000.0d, 0.00156835d },
            { 366000.0d, 0.0015619d },
            { 368000.0d, 0.0015554d },
            { 370000.0d, 0.00154885d },
            { 372000.0d, 0.00154225d },
            { 374000.0d, 0.0015356d },
            { 376000.0d, 0.0015289d },
            { 378000.0d, 0.00152216d },
            { 380000.0d, 0.00151536d },
            { 382000.0d, 0.00150851d },
            { 384000.0d, 0.00150161d },
            { 386000.0d, 0.00149465d },
            { 388000.0d, 0.00148765d },
            { 390000.0d, 0.00148059d },
            { 392000.0d, 0.00147348d },
            { 394000.0d, 0.00146632d },
            { 396000.0d, 0.0014591d },
            { 398000.0d, 0.00145183d },
            { 400000.0d, 0.00144451d },
            { 402000.0d, 0.00143713d },
            { 404000.0d, 0.0014297d },
            { 406000.0d, 0.00142222d },
            { 408000.0d, 0.00141468d },
            { 410000.0d, 0.00140708d },
            { 412000.0d, 0.00139943d },
            { 414000.0d, 0.00139173d },
            { 416000.0d, 0.00138397d },
            { 418000.0d, 0.00137615d },
            { 420000.0d, 0.00136828d },
            { 422000.0d, 0.00136035d },
            { 424000.0d, 0.00135237d },
            { 426000.0d, 0.00134433d },
            { 428000.0d, 0.00133623d },
            { 430000.0d, 0.00132808d },
            { 432000.0d, 0.00131987d },
            { 434000.0d, 0.0013116d },
            { 436000.0d, 0.00130328d },
            { 438000.0d, 0.0012949d },
            { 440000.0d, 0.00128647d },
            { 442000.0d, 0.00127797d },
            { 444000.0d, 0.00126943d },
            { 446000.0d, 0.00126082d },
            { 448000.0d, 0.00125216d },
            { 450000.0d, 0.00124344d },
            { 452000.0d, 0.00123467d },
            { 454000.0d, 0.00122584d },
            { 456000.0d, 0.00121696d },
            { 458000.0d, 0.00120802d },
            { 460000.0d, 0.00119902d },
            { 462000.0d, 0.00118997d },
            { 464000.0d, 0.00118086d },
            { 466000.0d, 0.0011717d },
            { 468000.0d, 0.00116249d },
            { 470000.0d, 0.00115322d },
            { 472000.0d, 0.00114389d },
            { 474000.0d, 0.00113451d },
            { 476000.0d, 0.00112508d },
            { 478000.0d, 0.0011156d },
            { 480000.0d, 0.00110606d },
            { 482000.0d, 0.00109647d },
            { 484000.0d, 0.00108683d },
            { 486000.0d, 0.00107714d },
            { 488000.0d, 0.0010674d },
            { 490000.0d, 0.00105761d },
            { 492000.0d, 0.00104777d },
            { 494000.0d, 0.00103788d },
            { 496000.0d, 0.00102794d },
            { 498000.0d, 0.00101795d },
            { 500000.0d, 0.00100792d },
            { 502000.0d, 0.000997836d },
            { 504000.0d, 0.00098771d },
            { 506000.0d, 0.000977539d },
            { 508000.0d, 0.000967324d },
            { 510000.0d, 0.000957066d },
            { 512000.0d, 0.000946765d },
            { 514000.0d, 0.000936423d },
            { 516000.0d, 0.000926039d },
            { 518000.0d, 0.000915616d },
            { 520000.0d, 0.000905154d },
            { 522000.0d, 0.000894655d },
            { 524000.0d, 0.000884118d },
            { 526000.0d, 0.000873545d },
            { 528000.0d, 0.000862938d },
            { 530000.0d, 0.000852297d },
            { 532000.0d, 0.000841624d },
            { 534000.0d, 0.000830919d },
            { 536000.0d, 0.000820185d },
            { 538000.0d, 0.000809421d },
            { 540000.0d, 0.00079863d },
            { 542000.0d, 0.000787813d },
            { 544000.0d, 0.000776971d },
            { 546000.0d, 0.000766106d },
            { 548000.0d, 0.000755219d },
            { 550000.0d, 0.000744311d },
            { 552000.0d, 0.000733385d },
            { 554000.0d, 0.000722441d },
            { 556000.0d, 0.000711481d },
            { 558000.0d, 0.000700507d },
            { 560000.0d, 0.000689521d },
            { 562000.0d, 0.000678524d },
            { 564000.0d, 0.000667518d },
            { 566000.0d, 0.000656504d },
            { 568000.0d, 0.000645485d },
            { 570000.0d, 0.000634463d },
            { 572000.0d, 0.00062344d },
            { 574000.0d, 0.000612416d },
            { 576000.0d, 0.000601395d },
            { 578000.0d, 0.000590379d },
            { 580000.0d, 0.000579369d },
            { 582000.0d, 0.000568368d },
            { 584000.0d, 0.000557378d },
            { 586000.0d, 0.000546401d },
            { 588000.0d, 0.000535439d },
            { 590000.0d, 0.000524495d },
            { 592000.0d, 0.000513572d },
            { 594000.0d, 0.000502671d },
            { 596000.0d, 0.000491794d },
            { 598000.0d, 0.000480946d },
            { 600000.0d, 0.000470128d },
            { 602000.0d, 0.000459342d },
            { 604000.0d, 0.000448592d },
            { 606000.0d, 0.00043788d },
            { 608000.0d, 0.000427209d },
            { 610000.0d, 0.000416582d },
            { 612000.0d, 0.000406001d },
            { 614000.0d, 0.00039547d },
            { 616000.0d, 0.000384992d },
            { 618000.0d, 0.000374569d },
            { 620000.0d, 0.000364205d },
            { 622000.0d, 0.000353902d },
            { 624000.0d, 0.000343665d },
            { 626000.0d, 0.000333496d },
            { 628000.0d, 0.000323399d },
            { 630000.0d, 0.000313376d },
            { 632000.0d, 0.000303432d },
            { 634000.0d, 0.00029357d },
            { 636000.0d, 0.000283793d },
            { 638000.0d, 0.000274105d },
            { 640000.0d, 0.00026451d },
            { 642000.0d, 0.000255011d },
            { 644000.0d, 0.000245613d },
            { 646000.0d, 0.000236318d },
            { 648000.0d, 0.000227132d },
            { 650000.0d, 0.000218057d },
            { 652000.0d, 0.000209098d },
            { 654000.0d, 0.000200259d },
            { 656000.0d, 0.000191544d },
            { 658000.0d, 0.000182957d },
            { 660000.0d, 0.000174503d },
            { 662000.0d, 0.000166186d },
            { 664000.0d, 0.000158011d },
            { 666000.0d, 0.000149981d },
            { 668000.0d, 0.000142101d },
            { 670000.0d, 0.000134377d },
            { 672000.0d, 0.000126812d },
            { 674000.0d, 0.000119411d },
            { 676000.0d, 0.000112179d },
            { 678000.0d, 0.000105121d },
            { 680000.0d, 0.0000982428d },
            { 682000.0d, 0.000091548d },
            { 684000.0d, 0.0000850422d },
            { 686000.0d, 0.0000787305d },
            { 688000.0d, 0.0000726181d },
            { 690000.0d, 0.0000667104d },
            { 692000.0d, 0.0000610127d },
            { 694000.0d, 0.0000555304d },
            { 696000.0d, 0.0000502689d },
            { 698000.0d, 0.000045234d },
            { 700000.0d, 0.0000404311d },
            { 702000.0d, 0.000035866d },
            { 704000.0d, 0.0000315445d },
            { 706000.0d, 0.0000274724d },
            { 708000.0d, 0.0000236556d },
            { 710000.0d, 0.0000201002d },
            { 712000.0d, 0.0000168121d },
            { 714000.0d, 0.0000137976d },
            { 716000.0d, 0.0000110627d },
            { 718000.0d, 0.00000861386d },
            { 720000.0d, 0.00000645728d },
            { 722000.0d, 0.00000459936d },
            { 724000.0d, 0.00000304652d },
            { 726000.0d, 0.00000180524d },
            { 728000.0d, 0.000000881989d },
            { 730000.0d, 0.000000283199d },
            { 732000.0d, 0.0000000151133d },
            { 732600.0d, 0d },

        }; 
    }
}
    