using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium127 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium127";
        public override double halfLife { get; } = 33660.0d;
        public override double atomicWeight { get; } = 126.90523d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine127()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.000297d, new GammaParticle(57630.0, 0.02151)), new(3.267e-05d, new GammaParticle(145200.0, 0.00854)), new(2.97e-06d, new GammaParticle(172100.0, 0.0072)), new(0.00058014d, new GammaParticle(202900.0, 0.00611)), new(0.00038709d, new GammaParticle(215100.0, 0.00576)), new(0.0013464000000000002d, new GammaParticle(360300.0, 0.00344)), new(2.97e-06d, new GammaParticle(375000.0, 0.00331)), new(0.009899999999999999d, new GammaParticle(417900.0, 0.00297)), new(1.2870000000000001e-06d, new GammaParticle(618400.0, 0.002)), new(0.0001159903631110356d, new GammaParticle(4335.0, 0.28601)), new(0.0003014298669459208d, new GammaParticle(28318.0, 0.04378)), new(0.0005598623085919778d, new GammaParticle(28613.0, 0.04333)), new(0.00016129908931770108d, new GammaParticle(32395.0, 0.03827)), new(0.0001977526835035015d, new GammaParticle(32680.0, 0.03794)), new(3.645359418580044e-05d, new GammaParticle(33040.0, 0.03753)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00248024d },
            { 200.0d, 0.00247957d },
            { 400.0d, 0.002479d },
            { 600.0d, 0.00247853d },
            { 800.0d, 0.00247816d },
            { 1000.0d, 0.00247789d },
            { 1500.0d, 0.00247763d },
            { 2000.0d, 0.00247798d },
            { 2500.0d, 0.00247892d },
            { 3000.0d, 0.0024801d },
            { 3500.0d, 0.0024812d },
            { 4000.0d, 0.00248234d },
            { 4500.0d, 0.0024835d },
            { 5000.0d, 0.00248468d },
            { 5500.0d, 0.0024859d },
            { 6000.0d, 0.00248714d },
            { 6500.0d, 0.00248806d },
            { 7000.0d, 0.00248889d },
            { 7500.0d, 0.0024896d },
            { 8000.0d, 0.00249022d },
            { 8500.0d, 0.00249087d },
            { 9000.0d, 0.00249147d },
            { 9500.0d, 0.00249202d },
            { 10000.0d, 0.00249253d },
            { 11000.0d, 0.00249353d },
            { 12000.0d, 0.00249444d },
            { 13000.0d, 0.00249528d },
            { 14000.0d, 0.00249606d },
            { 15000.0d, 0.00249679d },
            { 16000.0d, 0.00249747d },
            { 17000.0d, 0.0024981d },
            { 18000.0d, 0.00249867d },
            { 19000.0d, 0.00249922d },
            { 20000.0d, 0.00249972d },
            { 21000.0d, 0.00250019d },
            { 22000.0d, 0.00250061d },
            { 23000.0d, 0.00250101d },
            { 24000.0d, 0.00250137d },
            { 25000.0d, 0.00250171d },
            { 26000.0d, 0.00250201d },
            { 27000.0d, 0.00250228d },
            { 28000.0d, 0.00250253d },
            { 29000.0d, 0.00250275d },
            { 30000.0d, 0.00250295d },
            { 31000.0d, 0.00250313d },
            { 32000.0d, 0.00250328d },
            { 33000.0d, 0.00250342d },
            { 34000.0d, 0.00250353d },
            { 35000.0d, 0.00250363d },
            { 36000.0d, 0.0025037d },
            { 37000.0d, 0.00250376d },
            { 38000.0d, 0.00250379d },
            { 39000.0d, 0.0025038d },
            { 40000.0d, 0.0025038d },
            { 41000.0d, 0.00250378d },
            { 42000.0d, 0.00250374d },
            { 43000.0d, 0.00250368d },
            { 44000.0d, 0.00250361d },
            { 45000.0d, 0.00250352d },
            { 46000.0d, 0.00250341d },
            { 47000.0d, 0.00250329d },
            { 48000.0d, 0.00250315d },
            { 49000.0d, 0.00250299d },
            { 50000.0d, 0.00250282d },
            { 51000.0d, 0.00250262d },
            { 52000.0d, 0.00250241d },
            { 53000.0d, 0.00250219d },
            { 54000.0d, 0.00250195d },
            { 55000.0d, 0.00250169d },
            { 56000.0d, 0.00250141d },
            { 57000.0d, 0.00250111d },
            { 58000.0d, 0.0025008d },
            { 59000.0d, 0.00250047d },
            { 60000.0d, 0.00250012d },
            { 61000.0d, 0.00249976d },
            { 62000.0d, 0.00249937d },
            { 63000.0d, 0.00249898d },
            { 64000.0d, 0.00249856d },
            { 65000.0d, 0.00249812d },
            { 66000.0d, 0.00249767d },
            { 67000.0d, 0.0024972d },
            { 68000.0d, 0.00249671d },
            { 69000.0d, 0.0024962d },
            { 70000.0d, 0.00249567d },
            { 71000.0d, 0.00249512d },
            { 72000.0d, 0.00249456d },
            { 73000.0d, 0.00249397d },
            { 74000.0d, 0.00249337d },
            { 75000.0d, 0.00249275d },
            { 76000.0d, 0.00249211d },
            { 77000.0d, 0.00249144d },
            { 78000.0d, 0.00249076d },
            { 79000.0d, 0.00249006d },
            { 80000.0d, 0.00248934d },
            { 81000.0d, 0.0024886d },
            { 82000.0d, 0.00248784d },
            { 83000.0d, 0.00248706d },
            { 84000.0d, 0.00248627d },
            { 85000.0d, 0.00248545d },
            { 86000.0d, 0.00248461d },
            { 87000.0d, 0.00248374d },
            { 88000.0d, 0.00248286d },
            { 89000.0d, 0.00248196d },
            { 90000.0d, 0.00248104d },
            { 91000.0d, 0.00248009d },
            { 92000.0d, 0.00247913d },
            { 93000.0d, 0.00247815d },
            { 94000.0d, 0.00247714d },
            { 95000.0d, 0.00247611d },
            { 96000.0d, 0.00247506d },
            { 97000.0d, 0.00247399d },
            { 98000.0d, 0.0024729d },
            { 99000.0d, 0.00247179d },
            { 100000.0d, 0.00247066d },
            { 102000.0d, 0.00246833d },
            { 104000.0d, 0.00246591d },
            { 106000.0d, 0.00246341d },
            { 108000.0d, 0.00246081d },
            { 110000.0d, 0.00245813d },
            { 112000.0d, 0.00245537d },
            { 114000.0d, 0.00245251d },
            { 116000.0d, 0.00244956d },
            { 118000.0d, 0.00244654d },
            { 120000.0d, 0.00244341d },
            { 122000.0d, 0.00244021d },
            { 124000.0d, 0.00243691d },
            { 126000.0d, 0.00243353d },
            { 128000.0d, 0.00243005d },
            { 130000.0d, 0.00242648d },
            { 132000.0d, 0.00242283d },
            { 134000.0d, 0.00241909d },
            { 136000.0d, 0.00241526d },
            { 138000.0d, 0.00241134d },
            { 140000.0d, 0.00240733d },
            { 142000.0d, 0.00240323d },
            { 144000.0d, 0.00239904d },
            { 146000.0d, 0.00239477d },
            { 148000.0d, 0.0023904d },
            { 150000.0d, 0.00238594d },
            { 152000.0d, 0.0023814d },
            { 154000.0d, 0.00237678d },
            { 156000.0d, 0.00237206d },
            { 158000.0d, 0.00236726d },
            { 160000.0d, 0.00236237d },
            { 162000.0d, 0.00235739d },
            { 164000.0d, 0.00235232d },
            { 166000.0d, 0.00234718d },
            { 168000.0d, 0.00234194d },
            { 170000.0d, 0.00233662d },
            { 172000.0d, 0.00233121d },
            { 174000.0d, 0.00232572d },
            { 176000.0d, 0.00232014d },
            { 178000.0d, 0.00231448d },
            { 180000.0d, 0.00230874d },
            { 182000.0d, 0.00230292d },
            { 184000.0d, 0.002297d },
            { 186000.0d, 0.00229101d },
            { 188000.0d, 0.00228493d },
            { 190000.0d, 0.00227879d },
            { 192000.0d, 0.00227255d },
            { 194000.0d, 0.00226624d },
            { 196000.0d, 0.00225984d },
            { 198000.0d, 0.00225337d },
            { 200000.0d, 0.00224682d },
            { 202000.0d, 0.00224019d },
            { 204000.0d, 0.00223348d },
            { 206000.0d, 0.0022267d },
            { 208000.0d, 0.00221984d },
            { 210000.0d, 0.00221291d },
            { 212000.0d, 0.0022059d },
            { 214000.0d, 0.00219882d },
            { 216000.0d, 0.00219165d },
            { 218000.0d, 0.00218443d },
            { 220000.0d, 0.00217713d },
            { 222000.0d, 0.00216975d },
            { 224000.0d, 0.0021623d },
            { 226000.0d, 0.00215479d },
            { 228000.0d, 0.00214721d },
            { 230000.0d, 0.00213956d },
            { 232000.0d, 0.00213183d },
            { 234000.0d, 0.00212405d },
            { 236000.0d, 0.00211619d },
            { 238000.0d, 0.00210827d },
            { 240000.0d, 0.00210029d },
            { 242000.0d, 0.00209224d },
            { 244000.0d, 0.00208412d },
            { 246000.0d, 0.00207595d },
            { 248000.0d, 0.00206772d },
            { 250000.0d, 0.00205942d },
            { 252000.0d, 0.00205106d },
            { 254000.0d, 0.00204265d },
            { 256000.0d, 0.00203418d },
            { 258000.0d, 0.00202564d },
            { 260000.0d, 0.00201705d },
            { 262000.0d, 0.00200841d },
            { 264000.0d, 0.00199971d },
            { 266000.0d, 0.00199095d },
            { 268000.0d, 0.00198215d },
            { 270000.0d, 0.0019733d },
            { 272000.0d, 0.00196438d },
            { 274000.0d, 0.00195542d },
            { 276000.0d, 0.00194641d },
            { 278000.0d, 0.00193735d },
            { 280000.0d, 0.00192825d },
            { 282000.0d, 0.0019191d },
            { 284000.0d, 0.0019099d },
            { 286000.0d, 0.00190064d },
            { 288000.0d, 0.00189133d },
            { 290000.0d, 0.00188194d },
            { 292000.0d, 0.0018725d },
            { 294000.0d, 0.00186298d },
            { 296000.0d, 0.0018534d },
            { 298000.0d, 0.00184377d },
            { 300000.0d, 0.00183406d },
            { 302000.0d, 0.0018243d },
            { 304000.0d, 0.00181448d },
            { 306000.0d, 0.0018046d },
            { 308000.0d, 0.00179466d },
            { 310000.0d, 0.00178466d },
            { 312000.0d, 0.0017746d },
            { 314000.0d, 0.00176449d },
            { 316000.0d, 0.00175431d },
            { 318000.0d, 0.00174409d },
            { 320000.0d, 0.00173381d },
            { 322000.0d, 0.00172347d },
            { 324000.0d, 0.00171309d },
            { 326000.0d, 0.00170265d },
            { 328000.0d, 0.00169216d },
            { 330000.0d, 0.00168162d },
            { 332000.0d, 0.00167103d },
            { 334000.0d, 0.0016604d },
            { 336000.0d, 0.00164971d },
            { 338000.0d, 0.00163898d },
            { 340000.0d, 0.00162819d },
            { 342000.0d, 0.00161736d },
            { 344000.0d, 0.0016065d },
            { 346000.0d, 0.00159558d },
            { 348000.0d, 0.00158462d },
            { 350000.0d, 0.00157362d },
            { 352000.0d, 0.00156258d },
            { 354000.0d, 0.0015515d },
            { 356000.0d, 0.00154037d },
            { 358000.0d, 0.00152921d },
            { 360000.0d, 0.00151801d },
            { 362000.0d, 0.00150678d },
            { 364000.0d, 0.0014955d },
            { 366000.0d, 0.0014842d },
            { 368000.0d, 0.00147286d },
            { 370000.0d, 0.00146149d },
            { 372000.0d, 0.00145008d },
            { 374000.0d, 0.00143864d },
            { 376000.0d, 0.00142717d },
            { 378000.0d, 0.00141568d },
            { 380000.0d, 0.00140415d },
            { 382000.0d, 0.0013926d },
            { 384000.0d, 0.00138101d },
            { 386000.0d, 0.00136941d },
            { 388000.0d, 0.00135777d },
            { 390000.0d, 0.00134612d },
            { 392000.0d, 0.00133444d },
            { 394000.0d, 0.00132274d },
            { 396000.0d, 0.00131102d },
            { 398000.0d, 0.00129928d },
            { 400000.0d, 0.00128752d },
            { 402000.0d, 0.00127574d },
            { 404000.0d, 0.00126394d },
            { 406000.0d, 0.00125214d },
            { 408000.0d, 0.00124032d },
            { 410000.0d, 0.00122847d },
            { 412000.0d, 0.00121663d },
            { 414000.0d, 0.00120476d },
            { 416000.0d, 0.00119289d },
            { 418000.0d, 0.00118101d },
            { 420000.0d, 0.00116911d },
            { 422000.0d, 0.00115722d },
            { 424000.0d, 0.00114531d },
            { 426000.0d, 0.0011334d },
            { 428000.0d, 0.00112149d },
            { 430000.0d, 0.00110957d },
            { 432000.0d, 0.00109765d },
            { 434000.0d, 0.00108573d },
            { 436000.0d, 0.0010738d },
            { 438000.0d, 0.00106189d },
            { 440000.0d, 0.00104997d },
            { 442000.0d, 0.00103805d },
            { 444000.0d, 0.00102615d },
            { 446000.0d, 0.00101425d },
            { 448000.0d, 0.00100235d },
            { 450000.0d, 0.000990462d },
            { 452000.0d, 0.000978583d },
            { 454000.0d, 0.000966714d },
            { 456000.0d, 0.000954857d },
            { 458000.0d, 0.000943013d },
            { 460000.0d, 0.000931182d },
            { 462000.0d, 0.000919365d },
            { 464000.0d, 0.000907565d },
            { 466000.0d, 0.000895784d },
            { 468000.0d, 0.00088402d },
            { 470000.0d, 0.000872275d },
            { 472000.0d, 0.000860552d },
            { 474000.0d, 0.000848851d },
            { 476000.0d, 0.000837173d },
            { 478000.0d, 0.000825519d },
            { 480000.0d, 0.000813891d },
            { 482000.0d, 0.00080229d },
            { 484000.0d, 0.000790718d },
            { 486000.0d, 0.000779175d },
            { 488000.0d, 0.000767662d },
            { 490000.0d, 0.000756181d },
            { 492000.0d, 0.000744734d },
            { 494000.0d, 0.00073332d },
            { 496000.0d, 0.000721943d },
            { 498000.0d, 0.000710602d },
            { 500000.0d, 0.0006993d },
            { 502000.0d, 0.000688037d },
            { 504000.0d, 0.000676814d },
            { 506000.0d, 0.000665633d },
            { 508000.0d, 0.000654496d },
            { 510000.0d, 0.000643403d },
            { 512000.0d, 0.000632355d },
            { 514000.0d, 0.000621355d },
            { 516000.0d, 0.000610403d },
            { 518000.0d, 0.000599501d },
            { 520000.0d, 0.000588649d },
            { 522000.0d, 0.00057785d },
            { 524000.0d, 0.000567105d },
            { 526000.0d, 0.000556415d },
            { 528000.0d, 0.00054578d },
            { 530000.0d, 0.000535204d },
            { 532000.0d, 0.000524686d },
            { 534000.0d, 0.000514229d },
            { 536000.0d, 0.000503834d },
            { 538000.0d, 0.000493501d },
            { 540000.0d, 0.000483233d },
            { 542000.0d, 0.000473031d },
            { 544000.0d, 0.000462896d },
            { 546000.0d, 0.00045283d },
            { 548000.0d, 0.000442833d },
            { 550000.0d, 0.000432908d },
            { 552000.0d, 0.000423056d },
            { 554000.0d, 0.000413277d },
            { 556000.0d, 0.000403574d },
            { 558000.0d, 0.000393948d },
            { 560000.0d, 0.000384401d },
            { 562000.0d, 0.000374933d },
            { 564000.0d, 0.000365547d },
            { 566000.0d, 0.000356243d },
            { 568000.0d, 0.000347023d },
            { 570000.0d, 0.000337888d },
            { 572000.0d, 0.000328841d },
            { 574000.0d, 0.000319882d },
            { 576000.0d, 0.000311012d },
            { 578000.0d, 0.000302234d },
            { 580000.0d, 0.000293549d },
            { 582000.0d, 0.000284958d },
            { 584000.0d, 0.000276463d },
            { 586000.0d, 0.000268065d },
            { 588000.0d, 0.000259765d },
            { 590000.0d, 0.000251566d },
            { 592000.0d, 0.000243468d },
            { 594000.0d, 0.000235473d },
            { 596000.0d, 0.000227583d },
            { 598000.0d, 0.000219799d },
            { 600000.0d, 0.000212123d },
            { 602000.0d, 0.000204556d },
            { 604000.0d, 0.000197099d },
            { 606000.0d, 0.000189755d },
            { 608000.0d, 0.000182524d },
            { 610000.0d, 0.000175409d },
            { 612000.0d, 0.00016841d },
            { 614000.0d, 0.00016153d },
            { 616000.0d, 0.00015477d },
            { 618000.0d, 0.000148131d },
            { 620000.0d, 0.000141615d },
            { 622000.0d, 0.000135223d },
            { 624000.0d, 0.000128957d },
            { 626000.0d, 0.00012282d },
            { 628000.0d, 0.000116811d },
            { 630000.0d, 0.000110933d },
            { 632000.0d, 0.000105187d },
            { 634000.0d, 0.0000995759d },
            { 636000.0d, 0.0000940998d },
            { 638000.0d, 0.0000887608d },
            { 640000.0d, 0.0000835605d },
            { 642000.0d, 0.0000785006d },
            { 644000.0d, 0.0000735825d },
            { 646000.0d, 0.000068808d },
            { 648000.0d, 0.0000641786d },
            { 650000.0d, 0.0000596959d },
            { 652000.0d, 0.0000553616d },
            { 654000.0d, 0.0000511772d },
            { 656000.0d, 0.0000471444d },
            { 658000.0d, 0.0000432649d },
            { 660000.0d, 0.0000395402d },
            { 662000.0d, 0.000035972d },
            { 664000.0d, 0.000032562d },
            { 666000.0d, 0.0000293117d },
            { 668000.0d, 0.0000262228d },
            { 670000.0d, 0.0000232969d },
            { 672000.0d, 0.0000205358d },
            { 674000.0d, 0.000017941d },
            { 676000.0d, 0.0000155142d },
            { 678000.0d, 0.000013257d },
            { 680000.0d, 0.0000111711d },
            { 682000.0d, 0.00000925817d },
            { 684000.0d, 0.00000751984d },
            { 686000.0d, 0.00000595774d },
            { 688000.0d, 0.00000457354d },
            { 690000.0d, 0.00000336885d },
            { 692000.0d, 0.00000234531d },
            { 694000.0d, 0.00000150454d },
            { 696000.0d, 0.000000848116d },
            { 698000.0d, 0.000000377605d },
            { 700000.0d, 0.0000000944803d },
            { 702000.0d, 0d },

        }; 
    }
}
    