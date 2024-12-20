using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Americium245 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium245";
        public override double halfLife { get; } = 7380.0d;
        public override double atomicWeight { get; } = 245.06645d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium245()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.000258d, new GammaParticle(42870.0, 0.02892)), new(0.000258d, new GammaParticle(198000.0, 0.00626)), new(0.0015199999999999999d, new GammaParticle(240900.0, 0.00515)), new(0.055999999999999994d, new GammaParticle(252800.0, 0.0049)), new(0.00039d, new GammaParticle(255600.0, 0.00485)), new(2.8e-05d, new GammaParticle(266990.0, 0.00464)), new(0.00067d, new GammaParticle(295700.0, 0.00419)), new(0.000291d, new GammaParticle(333500.0, 0.00372)), new(7.000000000000001e-05d, new GammaParticle(348000.0, 0.00356)), new(3.9e-05d, new GammaParticle(380300.0, 0.00326)), new(0.00116d, new GammaParticle(388300.0, 0.00319)), new(0.000286d, new GammaParticle(391000.0, 0.00317)), new(0.000151d, new GammaParticle(643600.0, 0.00193)), new(0.0551661521514039d, new GammaParticle(18579.0, 0.06673)), new(0.02984233564103671d, new GammaParticle(104606.0, 0.01185)), new(0.046723556663592784d, new GammaParticle(109286.0, 0.01134)), new(0.01749915733885393d, new GammaParticle(123280.0, 0.01006)), new(0.023658860722130512d, new GammaParticle(124855.0, 0.00993)), new(0.006159703383276582d, new GammaParticle(126917.0, 0.00977)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00273229d },
            { 800.0d, 0.00267203d },
            { 1600.0d, 0.00261921d },
            { 2400.0d, 0.00257383d },
            { 3200.0d, 0.00253565d },
            { 4000.0d, 0.00250457d },
            { 4800.0d, 0.00248056d },
            { 5600.0d, 0.00246361d },
            { 6400.0d, 0.00245035d },
            { 7200.0d, 0.00243741d },
            { 8000.0d, 0.00242703d },
            { 8800.0d, 0.0024171d },
            { 9600.0d, 0.00240852d },
            { 10000.0d, 0.00240474d },
            { 11000.0d, 0.00239568d },
            { 12000.0d, 0.00238799d },
            { 13000.0d, 0.00238067d },
            { 14000.0d, 0.00237404d },
            { 15000.0d, 0.00236811d },
            { 16000.0d, 0.00236287d },
            { 17000.0d, 0.00235781d },
            { 18000.0d, 0.00235309d },
            { 19000.0d, 0.00234875d },
            { 20000.0d, 0.00234479d },
            { 21000.0d, 0.00234099d },
            { 22000.0d, 0.00233742d },
            { 23000.0d, 0.00233402d },
            { 24000.0d, 0.0023308d },
            { 25000.0d, 0.00232778d },
            { 26000.0d, 0.00232495d },
            { 27000.0d, 0.00232215d },
            { 28000.0d, 0.00231943d },
            { 29000.0d, 0.00231692d },
            { 30000.0d, 0.00231458d },
            { 31000.0d, 0.00231218d },
            { 32000.0d, 0.0023098d },
            { 33000.0d, 0.00230763d },
            { 34000.0d, 0.00230561d },
            { 35000.0d, 0.0023035d },
            { 36000.0d, 0.0023014d },
            { 37000.0d, 0.00229946d },
            { 38000.0d, 0.00229762d },
            { 39000.0d, 0.00229572d },
            { 40000.0d, 0.0022938d },
            { 41000.0d, 0.00229204d },
            { 42000.0d, 0.00229038d },
            { 43000.0d, 0.00228862d },
            { 44000.0d, 0.0022868d },
            { 45000.0d, 0.00228515d },
            { 46000.0d, 0.00228359d },
            { 47000.0d, 0.00228194d },
            { 48000.0d, 0.00228026d },
            { 49000.0d, 0.00227868d },
            { 50000.0d, 0.00227718d },
            { 51000.0d, 0.00227559d },
            { 52000.0d, 0.00227397d },
            { 53000.0d, 0.00227246d },
            { 54000.0d, 0.00227101d },
            { 55000.0d, 0.00226947d },
            { 56000.0d, 0.0022679d },
            { 57000.0d, 0.00226643d },
            { 58000.0d, 0.002265d },
            { 59000.0d, 0.00226349d },
            { 60000.0d, 0.00226193d },
            { 61000.0d, 0.00226047d },
            { 62000.0d, 0.00225907d },
            { 63000.0d, 0.00225758d },
            { 64000.0d, 0.00225603d },
            { 65000.0d, 0.00225458d },
            { 66000.0d, 0.00225317d },
            { 67000.0d, 0.00225168d },
            { 68000.0d, 0.00225016d },
            { 69000.0d, 0.00224871d },
            { 70000.0d, 0.0022473d },
            { 71000.0d, 0.00224581d },
            { 72000.0d, 0.00224426d },
            { 73000.0d, 0.00224278d },
            { 74000.0d, 0.00224134d },
            { 75000.0d, 0.00223982d },
            { 76000.0d, 0.00223827d },
            { 77000.0d, 0.0022368d },
            { 78000.0d, 0.00223537d },
            { 79000.0d, 0.00223386d },
            { 80000.0d, 0.0022323d },
            { 81000.0d, 0.00223079d },
            { 82000.0d, 0.00222929d },
            { 83000.0d, 0.00222773d },
            { 84000.0d, 0.00222614d },
            { 85000.0d, 0.00222462d },
            { 86000.0d, 0.00222313d },
            { 87000.0d, 0.00222156d },
            { 88000.0d, 0.00221995d },
            { 89000.0d, 0.00221838d },
            { 90000.0d, 0.00221683d },
            { 91000.0d, 0.00221524d },
            { 92000.0d, 0.00221362d },
            { 93000.0d, 0.00221201d },
            { 94000.0d, 0.00221041d },
            { 95000.0d, 0.00220878d },
            { 96000.0d, 0.00220715d },
            { 97000.0d, 0.00220551d },
            { 98000.0d, 0.00220386d },
            { 99000.0d, 0.00220219d },
            { 100000.0d, 0.00220052d },
            { 102000.0d, 0.00219715d },
            { 104000.0d, 0.00219376d },
            { 106000.0d, 0.00219034d },
            { 108000.0d, 0.00218682d },
            { 110000.0d, 0.00218334d },
            { 112000.0d, 0.00217972d },
            { 114000.0d, 0.00217617d },
            { 116000.0d, 0.0021725d },
            { 118000.0d, 0.00216881d },
            { 120000.0d, 0.0021651d },
            { 122000.0d, 0.00216132d },
            { 124000.0d, 0.00215748d },
            { 126000.0d, 0.00215366d },
            { 128000.0d, 0.00214976d },
            { 130000.0d, 0.0021458d },
            { 132000.0d, 0.00214178d },
            { 134000.0d, 0.00213778d },
            { 136000.0d, 0.00213371d },
            { 138000.0d, 0.00212957d },
            { 140000.0d, 0.00212537d },
            { 142000.0d, 0.00212118d },
            { 144000.0d, 0.00211695d },
            { 146000.0d, 0.00211268d },
            { 148000.0d, 0.00210831d },
            { 150000.0d, 0.0021039d },
            { 152000.0d, 0.00209943d },
            { 154000.0d, 0.00209497d },
            { 156000.0d, 0.00209046d },
            { 158000.0d, 0.00208592d },
            { 160000.0d, 0.00208132d },
            { 162000.0d, 0.00207666d },
            { 164000.0d, 0.00207196d },
            { 166000.0d, 0.0020672d },
            { 168000.0d, 0.00206239d },
            { 170000.0d, 0.00205755d },
            { 172000.0d, 0.00205269d },
            { 174000.0d, 0.00204777d },
            { 176000.0d, 0.00204282d },
            { 178000.0d, 0.00203783d },
            { 180000.0d, 0.00203279d },
            { 182000.0d, 0.00202771d },
            { 184000.0d, 0.00202258d },
            { 186000.0d, 0.00201741d },
            { 188000.0d, 0.00201221d },
            { 190000.0d, 0.00200696d },
            { 192000.0d, 0.00200165d },
            { 194000.0d, 0.00199631d },
            { 196000.0d, 0.00199094d },
            { 198000.0d, 0.00198552d },
            { 200000.0d, 0.00198005d },
            { 202000.0d, 0.00197456d },
            { 204000.0d, 0.00196901d },
            { 206000.0d, 0.00196343d },
            { 208000.0d, 0.0019578d },
            { 210000.0d, 0.00195214d },
            { 212000.0d, 0.00194644d },
            { 214000.0d, 0.0019407d },
            { 216000.0d, 0.00193493d },
            { 218000.0d, 0.00192912d },
            { 220000.0d, 0.00192327d },
            { 222000.0d, 0.00191738d },
            { 224000.0d, 0.00191146d },
            { 226000.0d, 0.00190552d },
            { 228000.0d, 0.00189953d },
            { 230000.0d, 0.0018935d },
            { 232000.0d, 0.00188743d },
            { 234000.0d, 0.00188132d },
            { 236000.0d, 0.00187516d },
            { 238000.0d, 0.00186898d },
            { 240000.0d, 0.00186276d },
            { 242000.0d, 0.00185652d },
            { 244000.0d, 0.00185024d },
            { 246000.0d, 0.00184395d },
            { 248000.0d, 0.00183761d },
            { 250000.0d, 0.00183124d },
            { 252000.0d, 0.00182483d },
            { 254000.0d, 0.00181838d },
            { 256000.0d, 0.0018119d },
            { 258000.0d, 0.00180538d },
            { 260000.0d, 0.00179882d },
            { 262000.0d, 0.00179223d },
            { 264000.0d, 0.00178563d },
            { 266000.0d, 0.00177898d },
            { 268000.0d, 0.0017723d },
            { 270000.0d, 0.00176557d },
            { 272000.0d, 0.00175881d },
            { 274000.0d, 0.00175202d },
            { 276000.0d, 0.00174521d },
            { 278000.0d, 0.00173837d },
            { 280000.0d, 0.00173149d },
            { 282000.0d, 0.00172458d },
            { 284000.0d, 0.00171764d },
            { 286000.0d, 0.00171066d },
            { 288000.0d, 0.00170364d },
            { 290000.0d, 0.0016966d },
            { 292000.0d, 0.00168954d },
            { 294000.0d, 0.00168245d },
            { 296000.0d, 0.00167533d },
            { 298000.0d, 0.00166818d },
            { 300000.0d, 0.00166099d },
            { 302000.0d, 0.00165379d },
            { 304000.0d, 0.00164655d },
            { 306000.0d, 0.0016393d },
            { 308000.0d, 0.00163201d },
            { 310000.0d, 0.0016247d },
            { 312000.0d, 0.00161737d },
            { 314000.0d, 0.00161d },
            { 316000.0d, 0.00160261d },
            { 318000.0d, 0.0015952d },
            { 320000.0d, 0.00158774d },
            { 322000.0d, 0.00158029d },
            { 324000.0d, 0.00157281d },
            { 326000.0d, 0.00156531d },
            { 328000.0d, 0.00155779d },
            { 330000.0d, 0.00155022d },
            { 332000.0d, 0.00154265d },
            { 334000.0d, 0.00153505d },
            { 336000.0d, 0.00152742d },
            { 338000.0d, 0.00151978d },
            { 340000.0d, 0.00151212d },
            { 342000.0d, 0.00150444d },
            { 344000.0d, 0.00149674d },
            { 346000.0d, 0.00148902d },
            { 348000.0d, 0.00148129d },
            { 350000.0d, 0.00147354d },
            { 352000.0d, 0.00146577d },
            { 354000.0d, 0.00145798d },
            { 356000.0d, 0.00145019d },
            { 358000.0d, 0.00144236d },
            { 360000.0d, 0.00143452d },
            { 362000.0d, 0.00142668d },
            { 364000.0d, 0.0014188d },
            { 366000.0d, 0.00141091d },
            { 368000.0d, 0.00140302d },
            { 370000.0d, 0.00139511d },
            { 372000.0d, 0.00138718d },
            { 374000.0d, 0.00137924d },
            { 376000.0d, 0.00137129d },
            { 378000.0d, 0.00136333d },
            { 380000.0d, 0.00135535d },
            { 382000.0d, 0.00134736d },
            { 384000.0d, 0.00133936d },
            { 386000.0d, 0.00133135d },
            { 388000.0d, 0.00132334d },
            { 390000.0d, 0.0013153d },
            { 392000.0d, 0.00130727d },
            { 394000.0d, 0.00129922d },
            { 396000.0d, 0.00129117d },
            { 398000.0d, 0.00128311d },
            { 400000.0d, 0.00127504d },
            { 402000.0d, 0.00126697d },
            { 404000.0d, 0.00125889d },
            { 406000.0d, 0.0012508d },
            { 408000.0d, 0.00124271d },
            { 410000.0d, 0.00123461d },
            { 412000.0d, 0.00122651d },
            { 414000.0d, 0.0012184d },
            { 416000.0d, 0.0012103d },
            { 418000.0d, 0.00120219d },
            { 420000.0d, 0.00119406d },
            { 422000.0d, 0.00118595d },
            { 424000.0d, 0.00117783d },
            { 426000.0d, 0.00116971d },
            { 428000.0d, 0.00116158d },
            { 430000.0d, 0.00115346d },
            { 432000.0d, 0.00114534d },
            { 434000.0d, 0.00113721d },
            { 436000.0d, 0.00112909d },
            { 438000.0d, 0.00112097d },
            { 440000.0d, 0.00111286d },
            { 442000.0d, 0.00110474d },
            { 444000.0d, 0.00109664d },
            { 446000.0d, 0.00108853d },
            { 448000.0d, 0.00108043d },
            { 450000.0d, 0.00107234d },
            { 452000.0d, 0.00106424d },
            { 454000.0d, 0.00105615d },
            { 456000.0d, 0.00104807d },
            { 458000.0d, 0.00103999d },
            { 460000.0d, 0.00103192d },
            { 462000.0d, 0.00102386d },
            { 464000.0d, 0.0010158d },
            { 466000.0d, 0.00100775d },
            { 468000.0d, 0.000999717d },
            { 470000.0d, 0.00099169d },
            { 472000.0d, 0.000983674d },
            { 474000.0d, 0.00097567d },
            { 476000.0d, 0.000967676d },
            { 478000.0d, 0.000959695d },
            { 480000.0d, 0.000951722d },
            { 482000.0d, 0.000943761d },
            { 484000.0d, 0.000935812d },
            { 486000.0d, 0.000927875d },
            { 488000.0d, 0.000919952d },
            { 490000.0d, 0.000912047d },
            { 492000.0d, 0.000904158d },
            { 494000.0d, 0.000896285d },
            { 496000.0d, 0.000888428d },
            { 498000.0d, 0.000880587d },
            { 500000.0d, 0.000872762d },
            { 502000.0d, 0.000864953d },
            { 504000.0d, 0.000857162d },
            { 506000.0d, 0.000849389d },
            { 508000.0d, 0.000841636d },
            { 510000.0d, 0.000833902d },
            { 512000.0d, 0.000826188d },
            { 514000.0d, 0.000818495d },
            { 516000.0d, 0.000810823d },
            { 518000.0d, 0.000803172d },
            { 520000.0d, 0.000795544d },
            { 522000.0d, 0.000787938d },
            { 524000.0d, 0.000780356d },
            { 526000.0d, 0.000772797d },
            { 528000.0d, 0.000765264d },
            { 530000.0d, 0.000757753d },
            { 532000.0d, 0.000750267d },
            { 534000.0d, 0.000742806d },
            { 536000.0d, 0.000735371d },
            { 538000.0d, 0.000727962d },
            { 540000.0d, 0.00072058d },
            { 542000.0d, 0.000713227d },
            { 544000.0d, 0.000705902d },
            { 546000.0d, 0.000698606d },
            { 548000.0d, 0.000691339d },
            { 550000.0d, 0.000684102d },
            { 552000.0d, 0.000676895d },
            { 554000.0d, 0.00066972d },
            { 556000.0d, 0.000662575d },
            { 558000.0d, 0.000655463d },
            { 560000.0d, 0.000648383d },
            { 562000.0d, 0.000641337d },
            { 564000.0d, 0.000634324d },
            { 566000.0d, 0.000627345d },
            { 568000.0d, 0.000620401d },
            { 570000.0d, 0.000613492d },
            { 572000.0d, 0.000606619d },
            { 574000.0d, 0.000599783d },
            { 576000.0d, 0.000592982d },
            { 578000.0d, 0.00058622d },
            { 580000.0d, 0.000579494d },
            { 582000.0d, 0.000572808d },
            { 584000.0d, 0.00056616d },
            { 586000.0d, 0.000559552d },
            { 588000.0d, 0.000552984d },
            { 590000.0d, 0.000546456d },
            { 592000.0d, 0.00053997d },
            { 594000.0d, 0.000533525d },
            { 596000.0d, 0.000527123d },
            { 598000.0d, 0.000520764d },
            { 600000.0d, 0.000514447d },
            { 602000.0d, 0.000508175d },
            { 604000.0d, 0.000501944d },
            { 606000.0d, 0.000495757d },
            { 608000.0d, 0.000489615d },
            { 610000.0d, 0.000483516d },
            { 612000.0d, 0.000477462d },
            { 614000.0d, 0.000471454d },
            { 616000.0d, 0.000465492d },
            { 618000.0d, 0.000459577d },
            { 620000.0d, 0.000453709d },
            { 622000.0d, 0.000447888d },
            { 624000.0d, 0.000442117d },
            { 626000.0d, 0.000436393d },
            { 628000.0d, 0.000430718d },
            { 630000.0d, 0.000425094d },
            { 632000.0d, 0.000419521d },
            { 634000.0d, 0.000413998d },
            { 636000.0d, 0.000408525d },
            { 638000.0d, 0.000403105d },
            { 640000.0d, 0.000397738d },
            { 642000.0d, 0.000392423d },
            { 644000.0d, 0.000387157d },
            { 646000.0d, 0.000381914d },
            { 648000.0d, 0.000376692d },
            { 650000.0d, 0.000371492d },
            { 652000.0d, 0.000366313d },
            { 654000.0d, 0.000361156d },
            { 656000.0d, 0.000356022d },
            { 658000.0d, 0.00035091d },
            { 660000.0d, 0.000345821d },
            { 662000.0d, 0.000340755d },
            { 664000.0d, 0.000335713d },
            { 666000.0d, 0.000330695d },
            { 668000.0d, 0.000325701d },
            { 670000.0d, 0.000320732d },
            { 672000.0d, 0.000315788d },
            { 674000.0d, 0.000310868d },
            { 676000.0d, 0.000305974d },
            { 678000.0d, 0.000301105d },
            { 680000.0d, 0.000296263d },
            { 682000.0d, 0.000291447d },
            { 684000.0d, 0.000286657d },
            { 686000.0d, 0.000281895d },
            { 688000.0d, 0.00027716d },
            { 690000.0d, 0.000272454d },
            { 692000.0d, 0.000267776d },
            { 694000.0d, 0.000263126d },
            { 696000.0d, 0.000258505d },
            { 698000.0d, 0.000253913d },
            { 700000.0d, 0.000249351d },
            { 702000.0d, 0.000244819d },
            { 704000.0d, 0.000240316d },
            { 706000.0d, 0.000235844d },
            { 708000.0d, 0.000231402d },
            { 710000.0d, 0.000226992d },
            { 712000.0d, 0.000222612d },
            { 714000.0d, 0.000218265d },
            { 716000.0d, 0.00021395d },
            { 718000.0d, 0.000209667d },
            { 720000.0d, 0.000205417d },
            { 722000.0d, 0.0002012d },
            { 724000.0d, 0.000197017d },
            { 726000.0d, 0.000192868d },
            { 728000.0d, 0.000188752d },
            { 730000.0d, 0.000184671d },
            { 732000.0d, 0.000180625d },
            { 734000.0d, 0.000176614d },
            { 736000.0d, 0.000172639d },
            { 738000.0d, 0.000168699d },
            { 740000.0d, 0.000164796d },
            { 742000.0d, 0.000160929d },
            { 744000.0d, 0.000157099d },
            { 746000.0d, 0.000153306d },
            { 748000.0d, 0.00014955d },
            { 750000.0d, 0.000145833d },
            { 752000.0d, 0.000142154d },
            { 754000.0d, 0.000138513d },
            { 756000.0d, 0.000134911d },
            { 758000.0d, 0.000131348d },
            { 760000.0d, 0.000127825d },
            { 762000.0d, 0.000124342d },
            { 764000.0d, 0.000120899d },
            { 766000.0d, 0.000117496d },
            { 768000.0d, 0.000114135d },
            { 770000.0d, 0.000110814d },
            { 772000.0d, 0.000107536d },
            { 774000.0d, 0.000104299d },
            { 776000.0d, 0.000101105d },
            { 778000.0d, 0.0000979532d },
            { 780000.0d, 0.0000948446d },
            { 782000.0d, 0.0000917792d },
            { 784000.0d, 0.0000887576d },
            { 786000.0d, 0.00008578d },
            { 788000.0d, 0.0000828468d },
            { 790000.0d, 0.0000799583d },
            { 792000.0d, 0.0000771148d },
            { 794000.0d, 0.0000743168d },
            { 796000.0d, 0.0000715645d },
            { 798000.0d, 0.0000688584d },
            { 800000.0d, 0.0000661987d },
            { 802000.0d, 0.0000635858d },
            { 804000.0d, 0.00006102d },
            { 806000.0d, 0.0000585018d },
            { 808000.0d, 0.0000560314d },
            { 810000.0d, 0.0000536093d },
            { 812000.0d, 0.0000512357d },
            { 814000.0d, 0.000048911d },
            { 816000.0d, 0.0000466355d },
            { 818000.0d, 0.0000444096d },
            { 820000.0d, 0.0000422337d },
            { 822000.0d, 0.0000401081d },
            { 824000.0d, 0.0000380331d },
            { 826000.0d, 0.0000360092d },
            { 828000.0d, 0.0000340366d },
            { 830000.0d, 0.0000321156d },
            { 832000.0d, 0.0000302467d },
            { 834000.0d, 0.0000284303d },
            { 836000.0d, 0.0000266665d },
            { 838000.0d, 0.0000249558d },
            { 840000.0d, 0.0000232986d },
            { 842000.0d, 0.0000216952d },
            { 844000.0d, 0.0000201459d },
            { 846000.0d, 0.000018651d },
            { 848000.0d, 0.0000172111d },
            { 850000.0d, 0.0000158262d },
            { 852000.0d, 0.000014497d },
            { 854000.0d, 0.0000132236d },
            { 856000.0d, 0.0000120064d },
            { 858000.0d, 0.0000108459d },
            { 860000.0d, 0.00000974221d },
            { 862000.0d, 0.00000869583d },
            { 864000.0d, 0.00000770707d },
            { 866000.0d, 0.00000677629d },
            { 868000.0d, 0.00000590381d },
            { 870000.0d, 0.00000508999d },
            { 872000.0d, 0.00000433517d },
            { 874000.0d, 0.00000363968d },
            { 876000.0d, 0.00000300389d },
            { 878000.0d, 0.00000242811d },
            { 880000.0d, 0.00000191268d },
            { 882000.0d, 0.00000145794d },
            { 884000.0d, 0.00000106422d },
            { 886000.0d, 0.000000731838d },
            { 888000.0d, 0.000000461109d },
            { 890000.0d, 0.000000252341d },
            { 892000.0d, 0.00000010582d },
            { 894000.0d, 0.0000000217989d },
            { 895900.0d, 0d },

        }; 
    }
}
    