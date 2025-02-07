using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ytterbium178 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium178";
        public override double halfLife { get; } = 4440.0d;
        public override double atomicWeight { get; } = 177.94667d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium178()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00390466d },
            { 800.0d, 0.0038913d },
            { 1600.0d, 0.00388137d },
            { 2400.0d, 0.00387488d },
            { 3200.0d, 0.00387051d },
            { 4000.0d, 0.00386708d },
            { 4800.0d, 0.00386415d },
            { 5600.0d, 0.00386155d },
            { 6400.0d, 0.0038588d },
            { 7200.0d, 0.00385543d },
            { 8000.0d, 0.00385176d },
            { 8800.0d, 0.00384781d },
            { 9600.0d, 0.00384358d },
            { 10000.0d, 0.00384137d },
            { 11000.0d, 0.00383569d },
            { 12000.0d, 0.00382972d },
            { 13000.0d, 0.00382356d },
            { 14000.0d, 0.0038172d },
            { 15000.0d, 0.0038107d },
            { 16000.0d, 0.00380405d },
            { 17000.0d, 0.0037973d },
            { 18000.0d, 0.00379042d },
            { 19000.0d, 0.00378346d },
            { 20000.0d, 0.0037764d },
            { 21000.0d, 0.00376926d },
            { 22000.0d, 0.00376204d },
            { 23000.0d, 0.00375476d },
            { 24000.0d, 0.0037474d },
            { 25000.0d, 0.00373997d },
            { 26000.0d, 0.00373249d },
            { 27000.0d, 0.00372494d },
            { 28000.0d, 0.00371733d },
            { 29000.0d, 0.00370966d },
            { 30000.0d, 0.00370195d },
            { 31000.0d, 0.00369418d },
            { 32000.0d, 0.00368635d },
            { 33000.0d, 0.00367848d },
            { 34000.0d, 0.00367056d },
            { 35000.0d, 0.00366259d },
            { 36000.0d, 0.00365457d },
            { 37000.0d, 0.0036465d },
            { 38000.0d, 0.00363838d },
            { 39000.0d, 0.00363023d },
            { 40000.0d, 0.00362203d },
            { 41000.0d, 0.00361379d },
            { 42000.0d, 0.00360551d },
            { 43000.0d, 0.00359719d },
            { 44000.0d, 0.00358883d },
            { 45000.0d, 0.00358044d },
            { 46000.0d, 0.003572d },
            { 47000.0d, 0.00356352d },
            { 48000.0d, 0.00355501d },
            { 49000.0d, 0.00354647d },
            { 50000.0d, 0.00353788d },
            { 51000.0d, 0.00352927d },
            { 52000.0d, 0.00352061d },
            { 53000.0d, 0.00351193d },
            { 54000.0d, 0.00350321d },
            { 55000.0d, 0.00349447d },
            { 56000.0d, 0.0034857d },
            { 57000.0d, 0.00347689d },
            { 58000.0d, 0.00346805d },
            { 59000.0d, 0.00345918d },
            { 60000.0d, 0.00345028d },
            { 61000.0d, 0.00344136d },
            { 62000.0d, 0.0034324d },
            { 63000.0d, 0.00342343d },
            { 64000.0d, 0.00341442d },
            { 65000.0d, 0.00340538d },
            { 66000.0d, 0.00339632d },
            { 67000.0d, 0.00338724d },
            { 68000.0d, 0.00337813d },
            { 69000.0d, 0.003369d },
            { 70000.0d, 0.00335984d },
            { 71000.0d, 0.00335066d },
            { 72000.0d, 0.00334146d },
            { 73000.0d, 0.00333223d },
            { 74000.0d, 0.00332298d },
            { 75000.0d, 0.00331371d },
            { 76000.0d, 0.00330442d },
            { 77000.0d, 0.00329511d },
            { 78000.0d, 0.00328578d },
            { 79000.0d, 0.00327644d },
            { 80000.0d, 0.00326707d },
            { 81000.0d, 0.00325769d },
            { 82000.0d, 0.00324828d },
            { 83000.0d, 0.00323885d },
            { 84000.0d, 0.00322941d },
            { 85000.0d, 0.00321995d },
            { 86000.0d, 0.00321048d },
            { 87000.0d, 0.00320099d },
            { 88000.0d, 0.00319148d },
            { 89000.0d, 0.00318196d },
            { 90000.0d, 0.00317243d },
            { 91000.0d, 0.00316288d },
            { 92000.0d, 0.00315332d },
            { 93000.0d, 0.00314374d },
            { 94000.0d, 0.00313415d },
            { 95000.0d, 0.00312455d },
            { 96000.0d, 0.00311493d },
            { 97000.0d, 0.00310531d },
            { 98000.0d, 0.00309567d },
            { 99000.0d, 0.00308602d },
            { 100000.0d, 0.00307637d },
            { 102000.0d, 0.00305701d },
            { 104000.0d, 0.00303764d },
            { 106000.0d, 0.00301822d },
            { 108000.0d, 0.00299877d },
            { 110000.0d, 0.0029793d },
            { 112000.0d, 0.00295981d },
            { 114000.0d, 0.0029403d },
            { 116000.0d, 0.00292078d },
            { 118000.0d, 0.00290125d },
            { 120000.0d, 0.00288169d },
            { 122000.0d, 0.00286215d },
            { 124000.0d, 0.0028426d },
            { 126000.0d, 0.00282306d },
            { 128000.0d, 0.00280352d },
            { 130000.0d, 0.00278399d },
            { 132000.0d, 0.00276448d },
            { 134000.0d, 0.00274498d },
            { 136000.0d, 0.00272551d },
            { 138000.0d, 0.00270606d },
            { 140000.0d, 0.00268664d },
            { 142000.0d, 0.00266726d },
            { 144000.0d, 0.00264791d },
            { 146000.0d, 0.00262861d },
            { 148000.0d, 0.00260935d },
            { 150000.0d, 0.00259014d },
            { 152000.0d, 0.00257099d },
            { 154000.0d, 0.00255189d },
            { 156000.0d, 0.00253286d },
            { 158000.0d, 0.00251388d },
            { 160000.0d, 0.00249498d },
            { 162000.0d, 0.00247616d },
            { 164000.0d, 0.00245741d },
            { 166000.0d, 0.00243874d },
            { 168000.0d, 0.00242017d },
            { 170000.0d, 0.00240169d },
            { 172000.0d, 0.00238329d },
            { 174000.0d, 0.002365d },
            { 176000.0d, 0.00234682d },
            { 178000.0d, 0.00232874d },
            { 180000.0d, 0.00231078d },
            { 182000.0d, 0.00229292d },
            { 184000.0d, 0.0022752d },
            { 186000.0d, 0.0022576d },
            { 188000.0d, 0.00224013d },
            { 190000.0d, 0.0022228d },
            { 192000.0d, 0.00220561d },
            { 194000.0d, 0.00218856d },
            { 196000.0d, 0.00217166d },
            { 198000.0d, 0.00215492d },
            { 200000.0d, 0.00213833d },
            { 202000.0d, 0.00212191d },
            { 204000.0d, 0.00210566d },
            { 206000.0d, 0.00208958d },
            { 208000.0d, 0.00207368d },
            { 210000.0d, 0.00205796d },
            { 212000.0d, 0.00204242d },
            { 214000.0d, 0.00202709d },
            { 216000.0d, 0.00201195d },
            { 218000.0d, 0.00199701d },
            { 220000.0d, 0.00198227d },
            { 222000.0d, 0.00196775d },
            { 224000.0d, 0.00195345d },
            { 226000.0d, 0.00193936d },
            { 228000.0d, 0.0019255d },
            { 230000.0d, 0.00191188d },
            { 232000.0d, 0.00189849d },
            { 234000.0d, 0.00188535d },
            { 236000.0d, 0.00187245d },
            { 238000.0d, 0.00185981d },
            { 240000.0d, 0.00184742d },
            { 242000.0d, 0.00183529d },
            { 244000.0d, 0.00182344d },
            { 246000.0d, 0.00181185d },
            { 248000.0d, 0.00180055d },
            { 250000.0d, 0.00178953d },
            { 252000.0d, 0.00177879d },
            { 254000.0d, 0.00176835d },
            { 256000.0d, 0.00175803d },
            { 258000.0d, 0.00174766d },
            { 260000.0d, 0.00173724d },
            { 262000.0d, 0.00172677d },
            { 264000.0d, 0.00171625d },
            { 266000.0d, 0.00170568d },
            { 268000.0d, 0.00169506d },
            { 270000.0d, 0.0016844d },
            { 272000.0d, 0.00167369d },
            { 274000.0d, 0.00166293d },
            { 276000.0d, 0.00165213d },
            { 278000.0d, 0.00164129d },
            { 280000.0d, 0.0016304d },
            { 282000.0d, 0.00161947d },
            { 284000.0d, 0.0016085d },
            { 286000.0d, 0.00159749d },
            { 288000.0d, 0.00158644d },
            { 290000.0d, 0.00157535d },
            { 292000.0d, 0.00156422d },
            { 294000.0d, 0.00155305d },
            { 296000.0d, 0.00154185d },
            { 298000.0d, 0.00153061d },
            { 300000.0d, 0.00151934d },
            { 302000.0d, 0.00150803d },
            { 304000.0d, 0.00149669d },
            { 306000.0d, 0.00148532d },
            { 308000.0d, 0.00147392d },
            { 310000.0d, 0.00146249d },
            { 312000.0d, 0.00145103d },
            { 314000.0d, 0.00143954d },
            { 316000.0d, 0.00142802d },
            { 318000.0d, 0.00141648d },
            { 320000.0d, 0.00140491d },
            { 322000.0d, 0.00139331d },
            { 324000.0d, 0.00138169d },
            { 326000.0d, 0.00137005d },
            { 328000.0d, 0.00135839d },
            { 330000.0d, 0.00134671d },
            { 332000.0d, 0.001335d },
            { 334000.0d, 0.00132328d },
            { 336000.0d, 0.00131154d },
            { 338000.0d, 0.00129978d },
            { 340000.0d, 0.00128801d },
            { 342000.0d, 0.00127622d },
            { 344000.0d, 0.00126441d },
            { 346000.0d, 0.0012526d },
            { 348000.0d, 0.00124077d },
            { 350000.0d, 0.00122893d },
            { 352000.0d, 0.00121708d },
            { 354000.0d, 0.00120522d },
            { 356000.0d, 0.00119335d },
            { 358000.0d, 0.00118147d },
            { 360000.0d, 0.00116959d },
            { 362000.0d, 0.00115771d },
            { 364000.0d, 0.00114582d },
            { 366000.0d, 0.00113392d },
            { 368000.0d, 0.00112203d },
            { 370000.0d, 0.00111013d },
            { 372000.0d, 0.00109824d },
            { 374000.0d, 0.00108634d },
            { 376000.0d, 0.00107445d },
            { 378000.0d, 0.00106256d },
            { 380000.0d, 0.00105068d },
            { 382000.0d, 0.0010388d },
            { 384000.0d, 0.00102692d },
            { 386000.0d, 0.00101506d },
            { 388000.0d, 0.0010032d },
            { 390000.0d, 0.000991357d },
            { 392000.0d, 0.000979521d },
            { 394000.0d, 0.000967698d },
            { 396000.0d, 0.000955888d },
            { 398000.0d, 0.000944092d },
            { 400000.0d, 0.000932311d },
            { 402000.0d, 0.000920547d },
            { 404000.0d, 0.000908801d },
            { 406000.0d, 0.000897073d },
            { 408000.0d, 0.000885365d },
            { 410000.0d, 0.000873679d },
            { 412000.0d, 0.000862014d },
            { 414000.0d, 0.000850373d },
            { 416000.0d, 0.000838756d },
            { 418000.0d, 0.000827166d },
            { 420000.0d, 0.000815601d },
            { 422000.0d, 0.000804065d },
            { 424000.0d, 0.000792559d },
            { 426000.0d, 0.000781082d },
            { 428000.0d, 0.000769637d },
            { 430000.0d, 0.000758225d },
            { 432000.0d, 0.000746847d },
            { 434000.0d, 0.000735504d },
            { 436000.0d, 0.000724197d },
            { 438000.0d, 0.000712928d },
            { 440000.0d, 0.000701698d },
            { 442000.0d, 0.000690507d },
            { 444000.0d, 0.000679358d },
            { 446000.0d, 0.000668251d },
            { 448000.0d, 0.000657188d },
            { 450000.0d, 0.00064617d },
            { 452000.0d, 0.000635198d },
            { 454000.0d, 0.000624273d },
            { 456000.0d, 0.000613397d },
            { 458000.0d, 0.00060257d },
            { 460000.0d, 0.000591795d },
            { 462000.0d, 0.000581072d },
            { 464000.0d, 0.000570403d },
            { 466000.0d, 0.000559788d },
            { 468000.0d, 0.00054923d },
            { 470000.0d, 0.00053873d },
            { 472000.0d, 0.000528287d },
            { 474000.0d, 0.000517905d },
            { 476000.0d, 0.000507585d },
            { 478000.0d, 0.000497327d },
            { 480000.0d, 0.000487132d },
            { 482000.0d, 0.000477003d },
            { 484000.0d, 0.000466941d },
            { 486000.0d, 0.000456946d },
            { 488000.0d, 0.00044702d },
            { 490000.0d, 0.000437165d },
            { 492000.0d, 0.000427381d },
            { 494000.0d, 0.000417671d },
            { 496000.0d, 0.000408035d },
            { 498000.0d, 0.000398474d },
            { 500000.0d, 0.000388991d },
            { 502000.0d, 0.000379586d },
            { 504000.0d, 0.000370261d },
            { 506000.0d, 0.000361017d },
            { 508000.0d, 0.000351856d },
            { 510000.0d, 0.000342778d },
            { 512000.0d, 0.000333785d },
            { 514000.0d, 0.000324879d },
            { 516000.0d, 0.000316061d },
            { 518000.0d, 0.000307333d },
            { 520000.0d, 0.000298694d },
            { 522000.0d, 0.000290148d },
            { 524000.0d, 0.000281696d },
            { 526000.0d, 0.000273338d },
            { 528000.0d, 0.000265076d },
            { 530000.0d, 0.000256912d },
            { 532000.0d, 0.000248847d },
            { 534000.0d, 0.000240883d },
            { 536000.0d, 0.00023302d },
            { 538000.0d, 0.00022526d },
            { 540000.0d, 0.000217605d },
            { 542000.0d, 0.000210056d },
            { 544000.0d, 0.000202615d },
            { 546000.0d, 0.000195283d },
            { 548000.0d, 0.00018806d },
            { 550000.0d, 0.00018095d },
            { 552000.0d, 0.000173953d },
            { 554000.0d, 0.000167071d },
            { 556000.0d, 0.000160304d },
            { 558000.0d, 0.000153655d },
            { 560000.0d, 0.000147126d },
            { 562000.0d, 0.000140716d },
            { 564000.0d, 0.000134429d },
            { 566000.0d, 0.000128265d },
            { 568000.0d, 0.000122225d },
            { 570000.0d, 0.000116312d },
            { 572000.0d, 0.000110527d },
            { 574000.0d, 0.000104871d },
            { 576000.0d, 0.0000993463d },
            { 578000.0d, 0.0000939533d },
            { 580000.0d, 0.0000886941d },
            { 582000.0d, 0.0000835701d },
            { 584000.0d, 0.0000785827d },
            { 586000.0d, 0.0000737335d },
            { 588000.0d, 0.0000690241d },
            { 590000.0d, 0.0000644557d },
            { 592000.0d, 0.0000600301d },
            { 594000.0d, 0.0000557487d },
            { 596000.0d, 0.0000516129d },
            { 598000.0d, 0.0000476244d },
            { 600000.0d, 0.0000437846d },
            { 602000.0d, 0.0000400951d },
            { 604000.0d, 0.0000365573d },
            { 606000.0d, 0.0000331728d },
            { 608000.0d, 0.0000299431d },
            { 610000.0d, 0.0000268698d },
            { 612000.0d, 0.0000239543d },
            { 614000.0d, 0.0000211982d },
            { 616000.0d, 0.000018603d },
            { 618000.0d, 0.0000161703d },
            { 620000.0d, 0.0000139016d },
            { 622000.0d, 0.0000117984d },
            { 624000.0d, 0.0000098623d },
            { 626000.0d, 0.00000809475d },
            { 628000.0d, 0.00000649731d },
            { 630000.0d, 0.0000050715d },
            { 632000.0d, 0.00000381886d },
            { 634000.0d, 0.00000274089d },
            { 636000.0d, 0.0000018391d },
            { 638000.0d, 0.00000111496d },
            { 640000.0d, 0.00000056995d },
            { 642000.0d, 0.000000205467d },
            { 644000.0d, 0.0000000228211d },
            { 645000.0d, 0d },

        }; 
    }
}
    