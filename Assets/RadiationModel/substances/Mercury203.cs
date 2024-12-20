using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury203 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury203";
        public override double halfLife { get; } = 4027104.0d;
        public override double atomicWeight { get; } = 202.97287d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium203()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.8156d, new GammaParticle(279195.2, 0.00444)), new(0.0538174736592d, new GammaParticle(12148.0, 0.10206)), new(0.03615202052238344d, new GammaParticle(70832.0, 0.0175)), new(0.06102636820118744d, new GammaParticle(72874.0, 0.01701)), new(0.020754366751294634d, new GammaParticle(82629.0, 0.015)), new(0.026918413676429137d, new GammaParticle(83631.0, 0.01483)), new(0.006164046925134507d, new GammaParticle(84866.0, 0.01461)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00982356d },
            { 700.0d, 0.0109142d },
            { 1400.0d, 0.0115241d },
            { 2100.0d, 0.011653d },
            { 2800.0d, 0.0116735d },
            { 3500.0d, 0.0116585d },
            { 4200.0d, 0.0116291d },
            { 4900.0d, 0.0115925d },
            { 5600.0d, 0.011552d },
            { 6300.0d, 0.0115089d },
            { 7000.0d, 0.0114639d },
            { 7700.0d, 0.0114176d },
            { 8400.0d, 0.0113702d },
            { 9100.0d, 0.0113219d },
            { 9800.0d, 0.0112728d },
            { 10000.0d, 0.0112587d },
            { 11000.0d, 0.0111874d },
            { 12000.0d, 0.011115d },
            { 13000.0d, 0.0110418d },
            { 14000.0d, 0.0109679d },
            { 15000.0d, 0.0108934d },
            { 16000.0d, 0.0108185d },
            { 17000.0d, 0.0107431d },
            { 18000.0d, 0.0106673d },
            { 19000.0d, 0.0105913d },
            { 20000.0d, 0.010515d },
            { 21000.0d, 0.0104384d },
            { 22000.0d, 0.0103617d },
            { 23000.0d, 0.0102847d },
            { 24000.0d, 0.0102077d },
            { 25000.0d, 0.0101305d },
            { 26000.0d, 0.0100531d },
            { 27000.0d, 0.00997563d },
            { 28000.0d, 0.00989807d },
            { 29000.0d, 0.00982041d },
            { 30000.0d, 0.00974269d },
            { 31000.0d, 0.00966491d },
            { 32000.0d, 0.00958707d },
            { 33000.0d, 0.00950918d },
            { 34000.0d, 0.00943126d },
            { 35000.0d, 0.00935331d },
            { 36000.0d, 0.00927534d },
            { 37000.0d, 0.00919735d },
            { 38000.0d, 0.00911935d },
            { 39000.0d, 0.00904135d },
            { 40000.0d, 0.00896335d },
            { 41000.0d, 0.00888537d },
            { 42000.0d, 0.0088074d },
            { 43000.0d, 0.00872945d },
            { 44000.0d, 0.00865154d },
            { 45000.0d, 0.00857365d },
            { 46000.0d, 0.0084958d },
            { 47000.0d, 0.00841801d },
            { 48000.0d, 0.00834026d },
            { 49000.0d, 0.00826257d },
            { 50000.0d, 0.00818493d },
            { 51000.0d, 0.00810737d },
            { 52000.0d, 0.00802987d },
            { 53000.0d, 0.00795246d },
            { 54000.0d, 0.00787513d },
            { 55000.0d, 0.00779788d },
            { 56000.0d, 0.00772072d },
            { 57000.0d, 0.00764366d },
            { 58000.0d, 0.00756671d },
            { 59000.0d, 0.00748985d },
            { 60000.0d, 0.00741312d },
            { 61000.0d, 0.0073365d },
            { 62000.0d, 0.00726d },
            { 63000.0d, 0.00718363d },
            { 64000.0d, 0.00710739d },
            { 65000.0d, 0.00703129d },
            { 66000.0d, 0.00695533d },
            { 67000.0d, 0.00687952d },
            { 68000.0d, 0.00680385d },
            { 69000.0d, 0.00672835d },
            { 70000.0d, 0.006653d },
            { 71000.0d, 0.00657783d },
            { 72000.0d, 0.00650281d },
            { 73000.0d, 0.00642798d },
            { 74000.0d, 0.00635333d },
            { 75000.0d, 0.00627886d },
            { 76000.0d, 0.00620458d },
            { 77000.0d, 0.0061305d },
            { 78000.0d, 0.00605661d },
            { 79000.0d, 0.00598294d },
            { 80000.0d, 0.00590946d },
            { 81000.0d, 0.0058362d },
            { 82000.0d, 0.00576316d },
            { 83000.0d, 0.00569035d },
            { 84000.0d, 0.00561776d },
            { 85000.0d, 0.0055454d },
            { 86000.0d, 0.00547328d },
            { 87000.0d, 0.00540141d },
            { 88000.0d, 0.00532978d },
            { 89000.0d, 0.00525841d },
            { 90000.0d, 0.00518729d },
            { 91000.0d, 0.00511642d },
            { 92000.0d, 0.00504584d },
            { 93000.0d, 0.00497552d },
            { 94000.0d, 0.00490548d },
            { 95000.0d, 0.00483571d },
            { 96000.0d, 0.00476623d },
            { 97000.0d, 0.00469704d },
            { 98000.0d, 0.00462815d },
            { 99000.0d, 0.00455957d },
            { 100000.0d, 0.00449127d },
            { 101000.0d, 0.0044233d },
            { 102000.0d, 0.00435564d },
            { 103000.0d, 0.00428829d },
            { 104000.0d, 0.00422128d },
            { 105000.0d, 0.00415459d },
            { 106000.0d, 0.00408824d },
            { 107000.0d, 0.00402222d },
            { 108000.0d, 0.00395655d },
            { 109000.0d, 0.00389123d },
            { 110000.0d, 0.00382626d },
            { 111000.0d, 0.00376165d },
            { 112000.0d, 0.00369741d },
            { 113000.0d, 0.00363353d },
            { 114000.0d, 0.00357003d },
            { 115000.0d, 0.0035069d },
            { 116000.0d, 0.00344416d },
            { 117000.0d, 0.00338181d },
            { 118000.0d, 0.00331985d },
            { 119000.0d, 0.0032583d },
            { 120000.0d, 0.00319714d },
            { 121000.0d, 0.00313639d },
            { 122000.0d, 0.00307605d },
            { 123000.0d, 0.00301614d },
            { 124000.0d, 0.00295665d },
            { 125000.0d, 0.00289759d },
            { 126000.0d, 0.00283895d },
            { 127000.0d, 0.00278077d },
            { 128000.0d, 0.00272302d },
            { 129000.0d, 0.00266573d },
            { 130000.0d, 0.00260889d },
            { 131000.0d, 0.0025525d },
            { 132000.0d, 0.00249658d },
            { 133000.0d, 0.00244113d },
            { 134000.0d, 0.00238616d },
            { 135000.0d, 0.00233166d },
            { 136000.0d, 0.00227766d },
            { 137000.0d, 0.00222413d },
            { 138000.0d, 0.00217111d },
            { 139000.0d, 0.00211859d },
            { 140000.0d, 0.00206657d },
            { 141000.0d, 0.00201507d },
            { 142000.0d, 0.00196408d },
            { 143000.0d, 0.00191361d },
            { 144000.0d, 0.00186367d },
            { 145000.0d, 0.00181426d },
            { 146000.0d, 0.00176538d },
            { 147000.0d, 0.00171706d },
            { 148000.0d, 0.00166928d },
            { 149000.0d, 0.00162205d },
            { 150000.0d, 0.00157538d },
            { 151000.0d, 0.00152927d },
            { 152000.0d, 0.00148374d },
            { 153000.0d, 0.00143877d },
            { 154000.0d, 0.0013944d },
            { 155000.0d, 0.0013506d },
            { 156000.0d, 0.00130739d },
            { 157000.0d, 0.00126478d },
            { 158000.0d, 0.00122276d },
            { 159000.0d, 0.00118136d },
            { 160000.0d, 0.00114057d },
            { 161000.0d, 0.0011004d },
            { 162000.0d, 0.00106085d },
            { 163000.0d, 0.00102193d },
            { 164000.0d, 0.000983639d },
            { 165000.0d, 0.000945991d },
            { 166000.0d, 0.000908987d },
            { 167000.0d, 0.000872633d },
            { 168000.0d, 0.000836936d },
            { 169000.0d, 0.0008019d },
            { 170000.0d, 0.00076753d },
            { 171000.0d, 0.000733832d },
            { 172000.0d, 0.000700813d },
            { 173000.0d, 0.000668476d },
            { 174000.0d, 0.000636829d },
            { 175000.0d, 0.000605876d },
            { 176000.0d, 0.000575624d },
            { 177000.0d, 0.000546076d },
            { 178000.0d, 0.00051724d },
            { 179000.0d, 0.000489121d },
            { 180000.0d, 0.000461725d },
            { 181000.0d, 0.000435056d },
            { 182000.0d, 0.000409121d },
            { 183000.0d, 0.000383925d },
            { 184000.0d, 0.000359474d },
            { 185000.0d, 0.000335775d },
            { 186000.0d, 0.00031283d },
            { 187000.0d, 0.000290648d },
            { 188000.0d, 0.000269234d },
            { 189000.0d, 0.000248593d },
            { 190000.0d, 0.00022873d },
            { 191000.0d, 0.000209653d },
            { 192000.0d, 0.000191366d },
            { 193000.0d, 0.000173875d },
            { 194000.0d, 0.000157186d },
            { 195000.0d, 0.000141304d },
            { 196000.0d, 0.000126235d },
            { 197000.0d, 0.000111987d },
            { 198000.0d, 0.0000985616d },
            { 199000.0d, 0.0000859675d },
            { 200000.0d, 0.0000742098d },
            { 201000.0d, 0.0000632939d },
            { 202000.0d, 0.000053226d },
            { 203000.0d, 0.0000440114d },
            { 204000.0d, 0.0000356565d },
            { 205000.0d, 0.0000281664d },
            { 206000.0d, 0.0000215472d },
            { 207000.0d, 0.0000158046d },
            { 208000.0d, 0.0000109442d },
            { 209000.0d, 0.000006972d },
            { 210000.0d, 0.00000389322d },
            { 211000.0d, 0.00000171395d },
            { 212000.0d, 0.000000439237d },
            { 213000.0d, 0.0000000696211d },
            { 214000.0d, 0.0000000693509d },
            { 215000.0d, 0.0000000690806d },
            { 216000.0d, 0.0000000688103d },
            { 217000.0d, 0.0000000685399d },
            { 218000.0d, 0.0000000682694d },
            { 219000.0d, 0.0000000679989d },
            { 220000.0d, 0.0000000677284d },
            { 221000.0d, 0.0000000674577d },
            { 222000.0d, 0.000000067187d },
            { 223000.0d, 0.0000000669161d },
            { 224000.0d, 0.0000000666452d },
            { 225000.0d, 0.0000000663741d },
            { 226000.0d, 0.000000066103d },
            { 227000.0d, 0.0000000658317d },
            { 228000.0d, 0.0000000655603d },
            { 229000.0d, 0.0000000652887d },
            { 230000.0d, 0.0000000650171d },
            { 231000.0d, 0.0000000647453d },
            { 232000.0d, 0.0000000644733d },
            { 233000.0d, 0.0000000642012d },
            { 234000.0d, 0.0000000639289d },
            { 235000.0d, 0.0000000636564d },
            { 236000.0d, 0.0000000633838d },
            { 237000.0d, 0.000000063111d },
            { 238000.0d, 0.000000062838d },
            { 239000.0d, 0.0000000625649d },
            { 240000.0d, 0.0000000622915d },
            { 241000.0d, 0.0000000620179d },
            { 242000.0d, 0.0000000617441d },
            { 243000.0d, 0.0000000614702d },
            { 244000.0d, 0.000000061196d },
            { 245000.0d, 0.0000000609215d },
            { 246000.0d, 0.0000000606469d },
            { 247000.0d, 0.000000060372d },
            { 248000.0d, 0.0000000600969d },
            { 249000.0d, 0.0000000598216d },
            { 250000.0d, 0.000000059546d },
            { 251000.0d, 0.0000000592701d },
            { 252000.0d, 0.000000058994d },
            { 253000.0d, 0.0000000587177d },
            { 254000.0d, 0.0000000584411d },
            { 255000.0d, 0.0000000581642d },
            { 256000.0d, 0.000000057887d },
            { 257000.0d, 0.0000000576096d },
            { 258000.0d, 0.0000000573319d },
            { 259000.0d, 0.0000000570539d },
            { 260000.0d, 0.0000000567756d },
            { 261000.0d, 0.0000000564971d },
            { 262000.0d, 0.0000000562182d },
            { 263000.0d, 0.0000000559391d },
            { 264000.0d, 0.0000000556597d },
            { 265000.0d, 0.0000000553799d },
            { 266000.0d, 0.0000000550999d },
            { 267000.0d, 0.0000000548195d },
            { 268000.0d, 0.0000000545389d },
            { 269000.0d, 0.0000000542579d },
            { 270000.0d, 0.0000000539766d },
            { 271000.0d, 0.000000053695d },
            { 272000.0d, 0.0000000534131d },
            { 273000.0d, 0.0000000531308d },
            { 274000.0d, 0.0000000528482d },
            { 275000.0d, 0.0000000525653d },
            { 276000.0d, 0.0000000522821d },
            { 277000.0d, 0.0000000519986d },
            { 278000.0d, 0.0000000517147d },
            { 279000.0d, 0.0000000514305d },
            { 280000.0d, 0.0000000511459d },
            { 281000.0d, 0.000000050861d },
            { 282000.0d, 0.0000000505758d },
            { 283000.0d, 0.0000000502903d },
            { 284000.0d, 0.0000000500044d },
            { 285000.0d, 0.0000000497182d },
            { 286000.0d, 0.0000000494316d },
            { 287000.0d, 0.0000000491447d },
            { 288000.0d, 0.0000000488575d },
            { 289000.0d, 0.0000000485699d },
            { 290000.0d, 0.000000048282d },
            { 291000.0d, 0.0000000479938d },
            { 292000.0d, 0.0000000477052d },
            { 293000.0d, 0.0000000474163d },
            { 294000.0d, 0.0000000471271d },
            { 295000.0d, 0.0000000468375d },
            { 296000.0d, 0.0000000465476d },
            { 297000.0d, 0.0000000462573d },
            { 298000.0d, 0.0000000459668d },
            { 299000.0d, 0.0000000456759d },
            { 300000.0d, 0.0000000453847d },
            { 301000.0d, 0.0000000450931d },
            { 302000.0d, 0.0000000448013d },
            { 303000.0d, 0.0000000445091d },
            { 304000.0d, 0.0000000442166d },
            { 305000.0d, 0.0000000439238d },
            { 306000.0d, 0.0000000436307d },
            { 307000.0d, 0.0000000433372d },
            { 308000.0d, 0.0000000430435d },
            { 309000.0d, 0.0000000427495d },
            { 310000.0d, 0.0000000424552d },
            { 311000.0d, 0.0000000421606d },
            { 312000.0d, 0.0000000418657d },
            { 313000.0d, 0.0000000415705d },
            { 314000.0d, 0.000000041275d },
            { 315000.0d, 0.0000000409793d },
            { 316000.0d, 0.0000000406833d },
            { 317000.0d, 0.000000040387d },
            { 318000.0d, 0.0000000400905d },
            { 319000.0d, 0.0000000397937d },
            { 320000.0d, 0.0000000394967d },
            { 321000.0d, 0.0000000391994d },
            { 322000.0d, 0.0000000389019d },
            { 323000.0d, 0.0000000386041d },
            { 324000.0d, 0.0000000383062d },
            { 325000.0d, 0.000000038008d },
            { 326000.0d, 0.0000000377096d },
            { 327000.0d, 0.000000037411d },
            { 328000.0d, 0.0000000371122d },
            { 329000.0d, 0.0000000368133d },
            { 330000.0d, 0.0000000365141d },
            { 331000.0d, 0.0000000362148d },
            { 332000.0d, 0.0000000359153d },
            { 333000.0d, 0.0000000356157d },
            { 334000.0d, 0.0000000353159d },
            { 335000.0d, 0.000000035016d },
            { 336000.0d, 0.0000000347159d },
            { 337000.0d, 0.0000000344158d },
            { 338000.0d, 0.0000000341155d },
            { 339000.0d, 0.0000000338151d },
            { 340000.0d, 0.0000000335147d },
            { 341000.0d, 0.0000000332141d },
            { 342000.0d, 0.0000000329135d },
            { 343000.0d, 0.0000000326129d },
            { 344000.0d, 0.0000000323122d },
            { 345000.0d, 0.0000000320114d },
            { 346000.0d, 0.0000000317107d },
            { 347000.0d, 0.0000000314099d },
            { 348000.0d, 0.0000000311092d },
            { 349000.0d, 0.0000000308084d },
            { 350000.0d, 0.0000000305077d },
            { 351000.0d, 0.000000030207d },
            { 352000.0d, 0.0000000299064d },
            { 353000.0d, 0.0000000296059d },
            { 354000.0d, 0.0000000293054d },
            { 355000.0d, 0.000000029005d },
            { 356000.0d, 0.0000000287047d },
            { 357000.0d, 0.0000000284046d },
            { 358000.0d, 0.0000000281046d },
            { 359000.0d, 0.0000000278048d },
            { 360000.0d, 0.0000000275051d },
            { 361000.0d, 0.0000000272056d },
            { 362000.0d, 0.0000000269063d },
            { 363000.0d, 0.0000000266073d },
            { 364000.0d, 0.0000000263084d },
            { 365000.0d, 0.0000000260099d },
            { 366000.0d, 0.0000000257115d },
            { 367000.0d, 0.0000000254135d },
            { 368000.0d, 0.0000000251158d },
            { 369000.0d, 0.0000000248184d },
            { 370000.0d, 0.0000000245214d },
            { 371000.0d, 0.0000000242247d },
            { 372000.0d, 0.0000000239284d },
            { 373000.0d, 0.0000000236325d },
            { 374000.0d, 0.000000023337d },
            { 375000.0d, 0.0000000230419d },
            { 376000.0d, 0.0000000227474d },
            { 377000.0d, 0.0000000224532d },
            { 378000.0d, 0.0000000221596d },
            { 379000.0d, 0.0000000218665d },
            { 380000.0d, 0.000000021574d },
            { 381000.0d, 0.000000021282d },
            { 382000.0d, 0.0000000209906d },
            { 383000.0d, 0.0000000206998d },
            { 384000.0d, 0.0000000204097d },
            { 385000.0d, 0.0000000201202d },
            { 386000.0d, 0.0000000198314d },
            { 387000.0d, 0.0000000195433d },
            { 388000.0d, 0.0000000192559d },
            { 389000.0d, 0.0000000189692d },
            { 390000.0d, 0.0000000186834d },
            { 391000.0d, 0.0000000183983d },
            { 392000.0d, 0.0000000181141d },
            { 393000.0d, 0.0000000178308d },
            { 394000.0d, 0.0000000175483d },
            { 395000.0d, 0.0000000172667d },
            { 396000.0d, 0.000000016986d },
            { 397000.0d, 0.0000000167064d },
            { 398000.0d, 0.0000000164277d },
            { 399000.0d, 0.00000001615d },
            { 400000.0d, 0.0000000158733d },
            { 401000.0d, 0.0000000155978d },
            { 402000.0d, 0.0000000153233d },
            { 403000.0d, 0.00000001505d },
            { 404000.0d, 0.0000000147779d },
            { 405000.0d, 0.0000000145069d },
            { 406000.0d, 0.0000000142371d },
            { 407000.0d, 0.0000000139687d },
            { 408000.0d, 0.0000000137015d },
            { 409000.0d, 0.0000000134356d },
            { 410000.0d, 0.0000000131711d },
            { 411000.0d, 0.0000000129079d },
            { 412000.0d, 0.0000000126462d },
            { 413000.0d, 0.0000000123859d },
            { 414000.0d, 0.0000000121271d },
            { 415000.0d, 0.0000000118698d },
            { 416000.0d, 0.0000000116141d },
            { 417000.0d, 0.00000001136d },
            { 418000.0d, 0.0000000111075d },
            { 419000.0d, 0.0000000108566d },
            { 420000.0d, 0.0000000106075d },
            { 421000.0d, 0.00000001036d },
            { 422000.0d, 0.0000000101144d },
            { 423000.0d, 0.00000000987053d },
            { 424000.0d, 0.00000000962852d },
            { 425000.0d, 0.00000000938839d },
            { 426000.0d, 0.00000000915018d },
            { 427000.0d, 0.00000000891394d },
            { 428000.0d, 0.00000000867969d },
            { 429000.0d, 0.00000000844748d },
            { 430000.0d, 0.00000000821736d },
            { 431000.0d, 0.00000000798935d },
            { 432000.0d, 0.0000000077635d },
            { 433000.0d, 0.00000000753986d },
            { 434000.0d, 0.00000000731847d },
            { 435000.0d, 0.00000000709936d },
            { 436000.0d, 0.00000000688258d },
            { 437000.0d, 0.00000000666818d },
            { 438000.0d, 0.00000000645619d },
            { 439000.0d, 0.00000000624667d },
            { 440000.0d, 0.00000000603966d },
            { 441000.0d, 0.00000000583519d },
            { 442000.0d, 0.00000000563333d },
            { 443000.0d, 0.00000000543411d },
            { 444000.0d, 0.00000000523758d },
            { 445000.0d, 0.00000000504379d },
            { 446000.0d, 0.00000000485279d },
            { 447000.0d, 0.00000000466462d },
            { 448000.0d, 0.00000000447933d },
            { 449000.0d, 0.00000000429697d },
            { 450000.0d, 0.00000000411759d },
            { 451000.0d, 0.00000000394125d },
            { 452000.0d, 0.00000000376798d },
            { 453000.0d, 0.00000000359784d },
            { 454000.0d, 0.00000000343089d },
            { 455000.0d, 0.00000000326717d },
            { 456000.0d, 0.00000000310673d },
            { 457000.0d, 0.00000000294964d },
            { 458000.0d, 0.00000000279593d },
            { 459000.0d, 0.00000000264568d },
            { 460000.0d, 0.00000000249892d },
            { 461000.0d, 0.00000000235572d },
            { 462000.0d, 0.00000000221612d },
            { 463000.0d, 0.00000000208019d },
            { 464000.0d, 0.00000000194799d },
            { 465000.0d, 0.00000000181956d },
            { 466000.0d, 0.00000000169496d },
            { 467000.0d, 0.00000000157426d },
            { 468000.0d, 0.00000000145751d },
            { 469000.0d, 0.00000000134477d },
            { 470000.0d, 0.00000000123609d },
            { 471000.0d, 0.00000000113155d },
            { 472000.0d, 0.00000000103119d },
            { 473000.0d, 0.000000000935078d },
            { 474000.0d, 0.000000000843277d },
            { 475000.0d, 0.000000000755846d },
            { 476000.0d, 0.000000000672848d },
            { 477000.0d, 0.000000000594345d },
            { 478000.0d, 0.0000000005204d },
            { 479000.0d, 0.000000000451076d },
            { 480000.0d, 0.000000000386438d },
            { 481000.0d, 0.00000000032655d },
            { 482000.0d, 0.000000000271476d },
            { 483000.0d, 0.000000000221281d },
            { 484000.0d, 0.000000000176033d },
            { 485000.0d, 0.000000000135795d },
            { 486000.0d, 0.000000000100635d },
            { 487000.0d, 0.0000000000706193d },
            { 488000.0d, 0.0000000000458144d },
            { 489000.0d, 0.0000000000262872d },
            { 490000.0d, 0.000000000012104d },
            { 491000.0d, 0.00000000000333026d },
            { 492000.0d, 0.0000000000000274825d },
            { 492100.0d, 0d },

        }; 
    }
}
    