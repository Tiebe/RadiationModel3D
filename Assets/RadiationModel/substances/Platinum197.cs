using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum197 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum197";
        public override double halfLife { get; } = 71609.4d;
        public override double atomicWeight { get; } = 196.96734d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold197()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.17204999999999998d, new GammaParticle(77350.0, 0.01603)), new(0.037000000000000005d, new GammaParticle(191437.0, 0.00648)), new(0.002331d, new GammaParticle(268780.0, 0.00461)), new(0.20156155802529038d, new GammaParticle(11419.0, 0.10858)), new(0.00997824852174928d, new GammaParticle(66991.0, 0.01851)), new(0.016987144231782905d, new GammaParticle(68806.0, 0.01802)), new(0.005731976427050286d, new GammaParticle(78048.0, 0.01589)), new(0.007388517614467818d, new GammaParticle(78983.0, 0.0157)), new(0.0016565411874175325d, new GammaParticle(80133.0, 0.01547)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00295902d },
            { 1000.0d, 0.0030003d },
            { 2000.0d, 0.00302922d },
            { 3000.0d, 0.00304578d },
            { 4000.0d, 0.00305669d },
            { 5000.0d, 0.00306294d },
            { 6000.0d, 0.00306477d },
            { 7000.0d, 0.00306732d },
            { 8000.0d, 0.00306894d },
            { 9000.0d, 0.00307029d },
            { 10000.0d, 0.00307118d },
            { 11000.0d, 0.00307183d },
            { 12000.0d, 0.00307218d },
            { 13000.0d, 0.00307236d },
            { 14000.0d, 0.00307233d },
            { 15000.0d, 0.00307217d },
            { 16000.0d, 0.00307186d },
            { 17000.0d, 0.00307145d },
            { 18000.0d, 0.00307091d },
            { 19000.0d, 0.00307029d },
            { 20000.0d, 0.00306958d },
            { 21000.0d, 0.0030688d },
            { 22000.0d, 0.00306795d },
            { 23000.0d, 0.00306702d },
            { 24000.0d, 0.00306603d },
            { 25000.0d, 0.00306498d },
            { 26000.0d, 0.00306388d },
            { 27000.0d, 0.00306272d },
            { 28000.0d, 0.00306151d },
            { 29000.0d, 0.00306025d },
            { 30000.0d, 0.00305893d },
            { 31000.0d, 0.00305757d },
            { 32000.0d, 0.00305616d },
            { 33000.0d, 0.00305471d },
            { 34000.0d, 0.00305321d },
            { 35000.0d, 0.00305167d },
            { 36000.0d, 0.00305008d },
            { 37000.0d, 0.00304846d },
            { 38000.0d, 0.0030468d },
            { 39000.0d, 0.00304509d },
            { 40000.0d, 0.00304334d },
            { 41000.0d, 0.00304155d },
            { 42000.0d, 0.00303972d },
            { 43000.0d, 0.00303785d },
            { 44000.0d, 0.00303595d },
            { 45000.0d, 0.00303401d },
            { 46000.0d, 0.00303203d },
            { 47000.0d, 0.00303001d },
            { 48000.0d, 0.00302796d },
            { 49000.0d, 0.00302587d },
            { 50000.0d, 0.00302374d },
            { 51000.0d, 0.00302158d },
            { 52000.0d, 0.00301938d },
            { 53000.0d, 0.00301714d },
            { 54000.0d, 0.00301488d },
            { 55000.0d, 0.00301258d },
            { 56000.0d, 0.00301024d },
            { 57000.0d, 0.00300787d },
            { 58000.0d, 0.00300546d },
            { 59000.0d, 0.00300302d },
            { 60000.0d, 0.00300054d },
            { 61000.0d, 0.00299803d },
            { 62000.0d, 0.00299549d },
            { 63000.0d, 0.00299292d },
            { 64000.0d, 0.00299032d },
            { 65000.0d, 0.00298768d },
            { 66000.0d, 0.002985d },
            { 67000.0d, 0.00298229d },
            { 68000.0d, 0.00297956d },
            { 69000.0d, 0.00297679d },
            { 70000.0d, 0.00297399d },
            { 71000.0d, 0.00297116d },
            { 72000.0d, 0.0029683d },
            { 73000.0d, 0.0029654d },
            { 74000.0d, 0.00296248d },
            { 75000.0d, 0.00295952d },
            { 76000.0d, 0.00295654d },
            { 77000.0d, 0.00295352d },
            { 78000.0d, 0.00295047d },
            { 79000.0d, 0.00294739d },
            { 80000.0d, 0.00294428d },
            { 81000.0d, 0.00294114d },
            { 82000.0d, 0.00293797d },
            { 83000.0d, 0.00293477d },
            { 84000.0d, 0.00293154d },
            { 85000.0d, 0.00292829d },
            { 86000.0d, 0.002925d },
            { 87000.0d, 0.00292169d },
            { 88000.0d, 0.00291834d },
            { 89000.0d, 0.00291496d },
            { 90000.0d, 0.00291156d },
            { 91000.0d, 0.00290812d },
            { 92000.0d, 0.00290466d },
            { 93000.0d, 0.00290117d },
            { 94000.0d, 0.00289764d },
            { 95000.0d, 0.00289409d },
            { 96000.0d, 0.00289052d },
            { 97000.0d, 0.00288691d },
            { 98000.0d, 0.00288328d },
            { 99000.0d, 0.00287962d },
            { 100000.0d, 0.00287593d },
            { 102000.0d, 0.00286846d },
            { 104000.0d, 0.0028609d },
            { 106000.0d, 0.00285321d },
            { 108000.0d, 0.00284542d },
            { 110000.0d, 0.00283752d },
            { 112000.0d, 0.0028295d },
            { 114000.0d, 0.00282139d },
            { 116000.0d, 0.00281317d },
            { 118000.0d, 0.00280484d },
            { 120000.0d, 0.00279641d },
            { 122000.0d, 0.00278788d },
            { 124000.0d, 0.00277923d },
            { 126000.0d, 0.00277049d },
            { 128000.0d, 0.00276165d },
            { 130000.0d, 0.00275271d },
            { 132000.0d, 0.00274367d },
            { 134000.0d, 0.00273453d },
            { 136000.0d, 0.00272528d },
            { 138000.0d, 0.00271594d },
            { 140000.0d, 0.00270651d },
            { 142000.0d, 0.00269697d },
            { 144000.0d, 0.00268734d },
            { 146000.0d, 0.00267762d },
            { 148000.0d, 0.0026678d },
            { 150000.0d, 0.00265789d },
            { 152000.0d, 0.00264789d },
            { 154000.0d, 0.0026378d },
            { 156000.0d, 0.0026276d },
            { 158000.0d, 0.00261733d },
            { 160000.0d, 0.00260697d },
            { 162000.0d, 0.00259651d },
            { 164000.0d, 0.00258597d },
            { 166000.0d, 0.00257533d },
            { 168000.0d, 0.00256462d },
            { 170000.0d, 0.00255382d },
            { 172000.0d, 0.00254293d },
            { 174000.0d, 0.00253196d },
            { 176000.0d, 0.00252092d },
            { 178000.0d, 0.00250978d },
            { 180000.0d, 0.00249856d },
            { 182000.0d, 0.00248727d },
            { 184000.0d, 0.00247589d },
            { 186000.0d, 0.00246444d },
            { 188000.0d, 0.00245291d },
            { 190000.0d, 0.00244131d },
            { 192000.0d, 0.00242962d },
            { 194000.0d, 0.00241786d },
            { 196000.0d, 0.00240603d },
            { 198000.0d, 0.00239412d },
            { 200000.0d, 0.00238214d },
            { 202000.0d, 0.0023701d },
            { 204000.0d, 0.00235798d },
            { 206000.0d, 0.00234578d },
            { 208000.0d, 0.00233352d },
            { 210000.0d, 0.0023212d },
            { 212000.0d, 0.00230882d },
            { 214000.0d, 0.00229635d },
            { 216000.0d, 0.00228383d },
            { 218000.0d, 0.00227124d },
            { 220000.0d, 0.00225859d },
            { 222000.0d, 0.00224589d },
            { 224000.0d, 0.00223312d },
            { 226000.0d, 0.00222028d },
            { 228000.0d, 0.0022074d },
            { 230000.0d, 0.00219445d },
            { 232000.0d, 0.00218145d },
            { 234000.0d, 0.00216839d },
            { 236000.0d, 0.00215527d },
            { 238000.0d, 0.00214211d },
            { 240000.0d, 0.0021289d },
            { 242000.0d, 0.00211562d },
            { 244000.0d, 0.0021023d },
            { 246000.0d, 0.00208893d },
            { 248000.0d, 0.00207552d },
            { 250000.0d, 0.00206205d },
            { 252000.0d, 0.00204854d },
            { 254000.0d, 0.00203498d },
            { 256000.0d, 0.00202139d },
            { 258000.0d, 0.00200775d },
            { 260000.0d, 0.00199406d },
            { 262000.0d, 0.00198034d },
            { 264000.0d, 0.00196657d },
            { 266000.0d, 0.00195277d },
            { 268000.0d, 0.00193894d },
            { 270000.0d, 0.00192506d },
            { 272000.0d, 0.00191116d },
            { 274000.0d, 0.00189721d },
            { 276000.0d, 0.00188324d },
            { 278000.0d, 0.00186924d },
            { 280000.0d, 0.00185521d },
            { 282000.0d, 0.00184114d },
            { 284000.0d, 0.00182706d },
            { 286000.0d, 0.00181294d },
            { 288000.0d, 0.0017988d },
            { 290000.0d, 0.00178462d },
            { 292000.0d, 0.00177044d },
            { 294000.0d, 0.00175623d },
            { 296000.0d, 0.001742d },
            { 298000.0d, 0.00172776d },
            { 300000.0d, 0.00171348d },
            { 302000.0d, 0.0016992d },
            { 304000.0d, 0.00168491d },
            { 306000.0d, 0.00167059d },
            { 308000.0d, 0.00165627d },
            { 310000.0d, 0.00164194d },
            { 312000.0d, 0.00162759d },
            { 314000.0d, 0.00161324d },
            { 316000.0d, 0.00159888d },
            { 318000.0d, 0.00158451d },
            { 320000.0d, 0.00157014d },
            { 322000.0d, 0.00155576d },
            { 324000.0d, 0.00154139d },
            { 326000.0d, 0.00152701d },
            { 328000.0d, 0.00151262d },
            { 330000.0d, 0.00149825d },
            { 332000.0d, 0.00148388d },
            { 334000.0d, 0.00146951d },
            { 336000.0d, 0.00145514d },
            { 338000.0d, 0.00144079d },
            { 340000.0d, 0.00142644d },
            { 342000.0d, 0.00141211d },
            { 344000.0d, 0.00139778d },
            { 346000.0d, 0.00138347d },
            { 348000.0d, 0.00136917d },
            { 350000.0d, 0.00135489d },
            { 352000.0d, 0.00134063d },
            { 354000.0d, 0.00132637d },
            { 356000.0d, 0.00131214d },
            { 358000.0d, 0.00129794d },
            { 360000.0d, 0.00128376d },
            { 362000.0d, 0.0012696d },
            { 364000.0d, 0.00125546d },
            { 366000.0d, 0.00124135d },
            { 368000.0d, 0.00122728d },
            { 370000.0d, 0.00121322d },
            { 372000.0d, 0.00119921d },
            { 374000.0d, 0.00118523d },
            { 376000.0d, 0.00117127d },
            { 378000.0d, 0.00115736d },
            { 380000.0d, 0.00114348d },
            { 382000.0d, 0.00112964d },
            { 384000.0d, 0.00111584d },
            { 386000.0d, 0.00110208d },
            { 388000.0d, 0.00108836d },
            { 390000.0d, 0.00107469d },
            { 392000.0d, 0.00106107d },
            { 394000.0d, 0.00104749d },
            { 396000.0d, 0.00103396d },
            { 398000.0d, 0.00102049d },
            { 400000.0d, 0.00100706d },
            { 402000.0d, 0.000993688d },
            { 404000.0d, 0.000980372d },
            { 406000.0d, 0.000967112d },
            { 408000.0d, 0.000953911d },
            { 410000.0d, 0.000940768d },
            { 412000.0d, 0.000927689d },
            { 414000.0d, 0.000914672d },
            { 416000.0d, 0.00090172d },
            { 418000.0d, 0.000888834d },
            { 420000.0d, 0.000876014d },
            { 422000.0d, 0.000863266d },
            { 424000.0d, 0.000850588d },
            { 426000.0d, 0.000837981d },
            { 428000.0d, 0.000825449d },
            { 430000.0d, 0.000812993d },
            { 432000.0d, 0.000800613d },
            { 434000.0d, 0.000788313d },
            { 436000.0d, 0.000776094d },
            { 438000.0d, 0.000763955d },
            { 440000.0d, 0.000751902d },
            { 442000.0d, 0.000739933d },
            { 444000.0d, 0.000728051d },
            { 446000.0d, 0.000716257d },
            { 448000.0d, 0.000704554d },
            { 450000.0d, 0.000692942d },
            { 452000.0d, 0.000681401d },
            { 454000.0d, 0.000669911d },
            { 456000.0d, 0.000658475d },
            { 458000.0d, 0.000647094d },
            { 460000.0d, 0.000635768d },
            { 462000.0d, 0.000624499d },
            { 464000.0d, 0.000613289d },
            { 466000.0d, 0.000602138d },
            { 468000.0d, 0.000591049d },
            { 470000.0d, 0.000580021d },
            { 472000.0d, 0.000569057d },
            { 474000.0d, 0.000558158d },
            { 476000.0d, 0.000547324d },
            { 478000.0d, 0.000536557d },
            { 480000.0d, 0.00052586d },
            { 482000.0d, 0.000515232d },
            { 484000.0d, 0.000504675d },
            { 486000.0d, 0.00049419d },
            { 488000.0d, 0.00048378d },
            { 490000.0d, 0.000473444d },
            { 492000.0d, 0.000463185d },
            { 494000.0d, 0.000453003d },
            { 496000.0d, 0.0004429d },
            { 498000.0d, 0.000432877d },
            { 500000.0d, 0.000422936d },
            { 502000.0d, 0.000413077d },
            { 504000.0d, 0.000403304d },
            { 506000.0d, 0.000393615d },
            { 508000.0d, 0.000384013d },
            { 510000.0d, 0.0003745d },
            { 512000.0d, 0.000365076d },
            { 514000.0d, 0.000355743d },
            { 516000.0d, 0.000346501d },
            { 518000.0d, 0.000337355d },
            { 520000.0d, 0.000328302d },
            { 522000.0d, 0.000319346d },
            { 524000.0d, 0.000310487d },
            { 526000.0d, 0.000301727d },
            { 528000.0d, 0.000293068d },
            { 530000.0d, 0.000284511d },
            { 532000.0d, 0.000276056d },
            { 534000.0d, 0.000267707d },
            { 536000.0d, 0.000259463d },
            { 538000.0d, 0.000251326d },
            { 540000.0d, 0.000243298d },
            { 542000.0d, 0.00023538d },
            { 544000.0d, 0.000227573d },
            { 546000.0d, 0.000219879d },
            { 548000.0d, 0.000212299d },
            { 550000.0d, 0.000204835d },
            { 552000.0d, 0.000197487d },
            { 554000.0d, 0.000190259d },
            { 556000.0d, 0.000183149d },
            { 558000.0d, 0.000176162d },
            { 560000.0d, 0.000169296d },
            { 562000.0d, 0.000162555d },
            { 564000.0d, 0.000155939d },
            { 566000.0d, 0.00014945d },
            { 568000.0d, 0.00014309d },
            { 570000.0d, 0.000136859d },
            { 572000.0d, 0.000130759d },
            { 574000.0d, 0.000124792d },
            { 576000.0d, 0.000118959d },
            { 578000.0d, 0.000113261d },
            { 580000.0d, 0.0001077d },
            { 582000.0d, 0.000102278d },
            { 584000.0d, 0.0000969956d },
            { 586000.0d, 0.0000918543d },
            { 588000.0d, 0.0000868557d },
            { 590000.0d, 0.0000820014d },
            { 592000.0d, 0.0000772926d },
            { 594000.0d, 0.000072731d },
            { 596000.0d, 0.0000683178d },
            { 598000.0d, 0.0000640547d },
            { 600000.0d, 0.000059943d },
            { 602000.0d, 0.0000559844d },
            { 604000.0d, 0.00005218d },
            { 606000.0d, 0.0000485316d },
            { 608000.0d, 0.0000450405d },
            { 610000.0d, 0.0000417082d },
            { 612000.0d, 0.0000385362d },
            { 614000.0d, 0.000035526d },
            { 616000.0d, 0.0000326789d },
            { 618000.0d, 0.0000299967d },
            { 620000.0d, 0.0000274806d },
            { 622000.0d, 0.0000251321d },
            { 624000.0d, 0.0000229528d },
            { 626000.0d, 0.0000209442d },
            { 628000.0d, 0.0000191075d },
            { 630000.0d, 0.0000174444d },
            { 632000.0d, 0.0000159562d },
            { 634000.0d, 0.0000146443d },
            { 636000.0d, 0.0000135103d },
            { 638000.0d, 0.0000125555d },
            { 640000.0d, 0.0000117811d },
            { 642000.0d, 0.0000111805d },
            { 644000.0d, 0.0000106335d },
            { 646000.0d, 0.0000100987d },
            { 648000.0d, 0.00000957627d },
            { 650000.0d, 0.00000906622d },
            { 652000.0d, 0.00000856873d },
            { 654000.0d, 0.00000808392d },
            { 656000.0d, 0.00000761191d },
            { 658000.0d, 0.00000715282d },
            { 660000.0d, 0.00000670678d },
            { 662000.0d, 0.00000627391d },
            { 664000.0d, 0.00000585432d },
            { 666000.0d, 0.00000544816d },
            { 668000.0d, 0.00000505552d },
            { 670000.0d, 0.00000467655d },
            { 672000.0d, 0.00000431136d },
            { 674000.0d, 0.00000396008d },
            { 676000.0d, 0.00000362283d },
            { 678000.0d, 0.00000329974d },
            { 680000.0d, 0.00000299092d },
            { 682000.0d, 0.00000269651d },
            { 684000.0d, 0.00000241663d },
            { 686000.0d, 0.00000215139d },
            { 688000.0d, 0.00000190093d },
            { 690000.0d, 0.00000166538d },
            { 692000.0d, 0.00000144484d },
            { 694000.0d, 0.00000123945d },
            { 696000.0d, 0.00000104934d },
            { 698000.0d, 0.00000087462d },
            { 700000.0d, 0.00000071542d },
            { 702000.0d, 0.000000571863d },
            { 704000.0d, 0.00000044407d },
            { 706000.0d, 0.000000332166d },
            { 708000.0d, 0.000000236269d },
            { 710000.0d, 0.000000156501d },
            { 712000.0d, 0.0000000929802d },
            { 714000.0d, 0.000000045821d },
            { 716000.0d, 0.0000000151335d },
            { 718000.0d, 0.00000000101538d },
            { 718700.0d, 0d },

        }; 
    }
}
    