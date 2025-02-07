using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ruthenium106 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium106";
        public override double halfLife { get; } = 32123520.0d;
        public override double atomicWeight { get; } = 105.90733d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhodium106()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0831883d },
            { 100.0d, 0.0795096d },
            { 200.0d, 0.0765686d },
            { 300.0d, 0.0743655d },
            { 400.0d, 0.0729524d },
            { 500.0d, 0.0719954d },
            { 600.0d, 0.0712994d },
            { 700.0d, 0.0707566d },
            { 800.0d, 0.0703064d },
            { 900.0d, 0.0699129d },
            { 1000.0d, 0.0695546d },
            { 1100.0d, 0.0692181d },
            { 1200.0d, 0.0688951d },
            { 1300.0d, 0.0685801d },
            { 1400.0d, 0.0682697d },
            { 1500.0d, 0.0679616d },
            { 1600.0d, 0.0676546d },
            { 1700.0d, 0.0673476d },
            { 1800.0d, 0.0670401d },
            { 1900.0d, 0.0667318d },
            { 2000.0d, 0.0664226d },
            { 2100.0d, 0.0661124d },
            { 2200.0d, 0.0658012d },
            { 2300.0d, 0.0654891d },
            { 2400.0d, 0.0651761d },
            { 2500.0d, 0.0648624d },
            { 2600.0d, 0.064548d },
            { 2700.0d, 0.064233d },
            { 2800.0d, 0.0639176d },
            { 2900.0d, 0.0636018d },
            { 3000.0d, 0.0632858d },
            { 3100.0d, 0.0629695d },
            { 3200.0d, 0.0626532d },
            { 3300.0d, 0.0623368d },
            { 3400.0d, 0.0620205d },
            { 3500.0d, 0.0617042d },
            { 3600.0d, 0.0613881d },
            { 3700.0d, 0.0610722d },
            { 3800.0d, 0.0607566d },
            { 3900.0d, 0.0604412d },
            { 4000.0d, 0.0601262d },
            { 4100.0d, 0.0598116d },
            { 4200.0d, 0.0594974d },
            { 4300.0d, 0.0591836d },
            { 4400.0d, 0.0588702d },
            { 4500.0d, 0.0585574d },
            { 4600.0d, 0.0582451d },
            { 4700.0d, 0.0579333d },
            { 4800.0d, 0.057622d },
            { 4900.0d, 0.0573113d },
            { 5000.0d, 0.0570012d },
            { 5100.0d, 0.0566917d },
            { 5200.0d, 0.0563828d },
            { 5300.0d, 0.0560745d },
            { 5400.0d, 0.0557668d },
            { 5500.0d, 0.0554598d },
            { 5600.0d, 0.0551534d },
            { 5700.0d, 0.0548477d },
            { 5800.0d, 0.0545426d },
            { 5900.0d, 0.0542382d },
            { 6000.0d, 0.0539345d },
            { 6100.0d, 0.0536315d },
            { 6200.0d, 0.0533292d },
            { 6300.0d, 0.0530276d },
            { 6400.0d, 0.0527266d },
            { 6500.0d, 0.0524264d },
            { 6600.0d, 0.0521269d },
            { 6700.0d, 0.051828d },
            { 6800.0d, 0.0515299d },
            { 6900.0d, 0.0512326d },
            { 7000.0d, 0.0509359d },
            { 7100.0d, 0.05064d },
            { 7200.0d, 0.0503447d },
            { 7300.0d, 0.0500503d },
            { 7400.0d, 0.0497565d },
            { 7500.0d, 0.0494635d },
            { 7600.0d, 0.0491712d },
            { 7700.0d, 0.0488797d },
            { 7800.0d, 0.0485889d },
            { 7900.0d, 0.0482989d },
            { 8000.0d, 0.0480096d },
            { 8100.0d, 0.047721d },
            { 8200.0d, 0.0474332d },
            { 8300.0d, 0.0471461d },
            { 8400.0d, 0.0468598d },
            { 8500.0d, 0.0465743d },
            { 8600.0d, 0.0462895d },
            { 8700.0d, 0.0460054d },
            { 8800.0d, 0.0457222d },
            { 8900.0d, 0.0454396d },
            { 9000.0d, 0.0451579d },
            { 9100.0d, 0.0448769d },
            { 9200.0d, 0.0445967d },
            { 9300.0d, 0.0443172d },
            { 9400.0d, 0.0440385d },
            { 9500.0d, 0.0437606d },
            { 9600.0d, 0.0434834d },
            { 9700.0d, 0.043207d },
            { 9800.0d, 0.0429314d },
            { 9900.0d, 0.0426565d },
            { 10000.0d, 0.0423825d },
            { 10000.0d, 0.0423825d },
            { 10100.0d, 0.0421092d },
            { 10200.0d, 0.0418367d },
            { 10300.0d, 0.0415649d },
            { 10400.0d, 0.041294d },
            { 10500.0d, 0.0410238d },
            { 10600.0d, 0.0407544d },
            { 10700.0d, 0.0404858d },
            { 10800.0d, 0.040218d },
            { 10900.0d, 0.0399509d },
            { 11000.0d, 0.0396847d },
            { 11100.0d, 0.0394192d },
            { 11200.0d, 0.0391546d },
            { 11300.0d, 0.0388907d },
            { 11400.0d, 0.0386276d },
            { 11500.0d, 0.0383653d },
            { 11600.0d, 0.0381038d },
            { 11700.0d, 0.0378431d },
            { 11800.0d, 0.0375832d },
            { 11900.0d, 0.0373241d },
            { 12000.0d, 0.0370657d },
            { 12100.0d, 0.0368082d },
            { 12200.0d, 0.0365515d },
            { 12300.0d, 0.0362956d },
            { 12400.0d, 0.0360405d },
            { 12500.0d, 0.0357862d },
            { 12600.0d, 0.0355327d },
            { 12700.0d, 0.03528d },
            { 12800.0d, 0.0350281d },
            { 12900.0d, 0.0347771d },
            { 13000.0d, 0.0345268d },
            { 13100.0d, 0.0342773d },
            { 13200.0d, 0.0340287d },
            { 13300.0d, 0.0337809d },
            { 13400.0d, 0.0335339d },
            { 13500.0d, 0.0332877d },
            { 13600.0d, 0.0330423d },
            { 13700.0d, 0.0327977d },
            { 13800.0d, 0.032554d },
            { 13900.0d, 0.0323111d },
            { 14000.0d, 0.032069d },
            { 14100.0d, 0.0318277d },
            { 14200.0d, 0.0315873d },
            { 14300.0d, 0.0313476d },
            { 14400.0d, 0.0311088d },
            { 14500.0d, 0.0308708d },
            { 14600.0d, 0.0306337d },
            { 14700.0d, 0.0303974d },
            { 14800.0d, 0.0301619d },
            { 14900.0d, 0.0299272d },
            { 15000.0d, 0.0296934d },
            { 15100.0d, 0.0294604d },
            { 15200.0d, 0.0292283d },
            { 15300.0d, 0.0289969d },
            { 15400.0d, 0.0287665d },
            { 15500.0d, 0.0285368d },
            { 15600.0d, 0.028308d },
            { 15700.0d, 0.02808d },
            { 15800.0d, 0.0278529d },
            { 15900.0d, 0.0276266d },
            { 16000.0d, 0.0274012d },
            { 16100.000000000002d, 0.0271766d },
            { 16200.0d, 0.0269528d },
            { 16300.0d, 0.0267299d },
            { 16400.0d, 0.0265079d },
            { 16500.0d, 0.0262866d },
            { 16600.0d, 0.0260663d },
            { 16700.0d, 0.0258468d },
            { 16800.0d, 0.0256281d },
            { 16900.0d, 0.0254103d },
            { 17000.0d, 0.0251933d },
            { 17100.0d, 0.0249772d },
            { 17200.0d, 0.024762d },
            { 17300.0d, 0.0245476d },
            { 17400.0d, 0.0243341d },
            { 17500.0d, 0.0241214d },
            { 17600.0d, 0.0239096d },
            { 17700.0d, 0.0236986d },
            { 17800.0d, 0.0234885d },
            { 17900.0d, 0.0232793d },
            { 18000.0d, 0.0230709d },
            { 18100.0d, 0.0228634d },
            { 18200.0d, 0.0226568d },
            { 18300.0d, 0.022451d },
            { 18400.0d, 0.0222461d },
            { 18500.0d, 0.0220421d },
            { 18600.0d, 0.0218389d },
            { 18700.0d, 0.0216367d },
            { 18800.0d, 0.0214352d },
            { 18900.0d, 0.0212347d },
            { 19000.0d, 0.021035d },
            { 19100.0d, 0.0208362d },
            { 19200.0d, 0.0206383d },
            { 19300.0d, 0.0204412d },
            { 19400.0d, 0.0202451d },
            { 19500.0d, 0.0200498d },
            { 19600.0d, 0.0198554d },
            { 19700.0d, 0.0196619d },
            { 19800.0d, 0.0194692d },
            { 19900.0d, 0.0192774d },
            { 20000.0d, 0.0190866d },
            { 20100.0d, 0.0188966d },
            { 20200.0d, 0.0187075d },
            { 20300.0d, 0.0185192d },
            { 20400.0d, 0.0183319d },
            { 20500.0d, 0.0181455d },
            { 20600.0d, 0.0179599d },
            { 20700.0d, 0.0177752d },
            { 20800.0d, 0.0175915d },
            { 20900.0d, 0.0174086d },
            { 21000.0d, 0.0172266d },
            { 21100.0d, 0.0170455d },
            { 21200.0d, 0.0168653d },
            { 21300.0d, 0.016686d },
            { 21400.0d, 0.0165076d },
            { 21500.0d, 0.0163301d },
            { 21600.0d, 0.0161535d },
            { 21700.0d, 0.0159778d },
            { 21800.0d, 0.015803d },
            { 21900.0d, 0.0156291d },
            { 22000.0d, 0.0154561d },
            { 22100.0d, 0.015284d },
            { 22200.0d, 0.0151128d },
            { 22300.0d, 0.0149425d },
            { 22400.0d, 0.0147732d },
            { 22500.0d, 0.0146047d },
            { 22600.0d, 0.0144372d },
            { 22700.0d, 0.0142705d },
            { 22800.0d, 0.0141048d },
            { 22900.0d, 0.01394d },
            { 23000.0d, 0.0137761d },
            { 23100.0d, 0.0136131d },
            { 23200.0d, 0.013451d },
            { 23300.0d, 0.0132899d },
            { 23400.0d, 0.0131296d },
            { 23500.0d, 0.0129703d },
            { 23600.0d, 0.0128119d },
            { 23700.0d, 0.0126544d },
            { 23800.0d, 0.0124978d },
            { 23900.0d, 0.0123422d },
            { 24000.0d, 0.0121875d },
            { 24100.0d, 0.0120337d },
            { 24200.0d, 0.0118808d },
            { 24300.0d, 0.0117289d },
            { 24400.0d, 0.0115779d },
            { 24500.0d, 0.0114278d },
            { 24600.0d, 0.0112786d },
            { 24700.0d, 0.0111304d },
            { 24800.0d, 0.0109831d },
            { 24900.0d, 0.0108368d },
            { 25000.0d, 0.0106913d },
            { 25100.0d, 0.0105468d },
            { 25200.0d, 0.0104033d },
            { 25300.0d, 0.0102607d },
            { 25400.0d, 0.010119d },
            { 25500.0d, 0.00997824d },
            { 25600.0d, 0.00983843d },
            { 25700.0d, 0.00969956d },
            { 25800.0d, 0.00956163d },
            { 25900.0d, 0.00942465d },
            { 26000.0d, 0.00928861d },
            { 26100.0d, 0.00915351d },
            { 26200.0d, 0.00901936d },
            { 26300.0d, 0.00888615d },
            { 26400.0d, 0.00875389d },
            { 26500.0d, 0.00862258d },
            { 26600.0d, 0.00849221d },
            { 26700.0d, 0.0083628d },
            { 26800.0d, 0.00823434d },
            { 26900.0d, 0.00810683d },
            { 27000.0d, 0.00798027d },
            { 27100.0d, 0.00785467d },
            { 27200.0d, 0.00773002d },
            { 27300.0d, 0.00760633d },
            { 27400.0d, 0.00748359d },
            { 27500.0d, 0.00736181d },
            { 27600.0d, 0.00724099d },
            { 27700.0d, 0.00712113d },
            { 27800.0d, 0.00700223d },
            { 27900.0d, 0.0068843d },
            { 28000.0d, 0.00676732d },
            { 28100.0d, 0.00665131d },
            { 28200.0d, 0.00653627d },
            { 28300.0d, 0.00642219d },
            { 28400.0d, 0.00630907d },
            { 28500.0d, 0.00619693d },
            { 28600.0d, 0.00608575d },
            { 28700.0d, 0.00597554d },
            { 28800.0d, 0.00586631d },
            { 28900.0d, 0.00575804d },
            { 29000.0d, 0.00565075d },
            { 29100.0d, 0.00554443d },
            { 29200.0d, 0.00543909d },
            { 29300.0d, 0.00533472d },
            { 29400.0d, 0.00523133d },
            { 29500.0d, 0.00512892d },
            { 29600.0d, 0.00502749d },
            { 29700.0d, 0.00492703d },
            { 29800.0d, 0.00482756d },
            { 29900.0d, 0.00472907d },
            { 30000.0d, 0.00463156d },
            { 30100.0d, 0.00453504d },
            { 30200.0d, 0.0044395d },
            { 30300.0d, 0.00434494d },
            { 30400.0d, 0.00425137d },
            { 30500.0d, 0.00415879d },
            { 30600.0d, 0.0040672d },
            { 30700.0d, 0.0039766d },
            { 30800.0d, 0.00388699d },
            { 30900.0d, 0.00379837d },
            { 31000.0d, 0.00371075d },
            { 31100.0d, 0.00362412d },
            { 31200.0d, 0.00353848d },
            { 31300.0d, 0.00345384d },
            { 31400.0d, 0.0033702d },
            { 31500.0d, 0.00328755d },
            { 31600.0d, 0.00320591d },
            { 31700.0d, 0.00312526d },
            { 31800.0d, 0.00304561d },
            { 31900.0d, 0.00296697d },
            { 32000.0d, 0.00288933d },
            { 32100.0d, 0.00281269d },
            { 32200.000000000004d, 0.00273706d },
            { 32299.999999999996d, 0.00266244d },
            { 32400.0d, 0.00258882d },
            { 32500.0d, 0.00251621d },
            { 32600.0d, 0.00244461d },
            { 32700.000000000004d, 0.00237402d },
            { 32800.0d, 0.00230444d },
            { 32900.0d, 0.00223587d },
            { 33000.0d, 0.00216832d },
            { 33100.0d, 0.00210178d },
            { 33200.0d, 0.00203625d },
            { 33300.0d, 0.00197175d },
            { 33400.0d, 0.00190826d },
            { 33500.0d, 0.00184578d },
            { 33600.0d, 0.00178433d },
            { 33700.0d, 0.0017239d },
            { 33800.0d, 0.00166449d },
            { 33900.0d, 0.0016061d },
            { 34000.0d, 0.00154874d },
            { 34100.0d, 0.0014924d },
            { 34200.0d, 0.00143708d },
            { 34300.0d, 0.0013828d },
            { 34400.0d, 0.00132954d },
            { 34500.0d, 0.00127731d },
            { 34600.0d, 0.00122611d },
            { 34700.0d, 0.00117594d },
            { 34800.0d, 0.0011268d },
            { 34900.0d, 0.00107869d },
            { 35000.0d, 0.00103162d },
            { 35100.0d, 0.000985585d },
            { 35200.0d, 0.000940584d },
            { 35300.0d, 0.000896621d },
            { 35400.0d, 0.000853696d },
            { 35500.0d, 0.00081181d },
            { 35600.0d, 0.000770964d },
            { 35700.0d, 0.00073116d },
            { 35800.0d, 0.000692398d },
            { 35900.0d, 0.000654679d },
            { 36000.0d, 0.000618005d },
            { 36100.0d, 0.000582376d },
            { 36200.0d, 0.000547794d },
            { 36300.0d, 0.000514259d },
            { 36400.0d, 0.000481773d },
            { 36500.0d, 0.000450336d },
            { 36600.0d, 0.00041995d },
            { 36700.0d, 0.000390616d },
            { 36800.0d, 0.000362335d },
            { 36900.0d, 0.000335107d },
            { 37000.0d, 0.000308935d },
            { 37100.0d, 0.000283818d },
            { 37200.0d, 0.000259759d },
            { 37300.0d, 0.000236757d },
            { 37400.0d, 0.000214815d },
            { 37500.0d, 0.000193933d },
            { 37600.0d, 0.000174112d },
            { 37700.0d, 0.000155353d },
            { 37800.0d, 0.000137657d },
            { 37900.0d, 0.000121026d },
            { 38000.0d, 0.000105461d },
            { 38100.0d, 0.0000909618d },
            { 38200.0d, 0.0000775302d },
            { 38300.0d, 0.0000651673d },
            { 38400.0d, 0.000053874d },
            { 38500.0d, 0.0000436514d },
            { 38600.0d, 0.0000345005d },
            { 38700.0d, 0.0000264224d },
            { 38800.0d, 0.0000194181d },
            { 38900.0d, 0.0000134887d },
            { 39000.0d, 0.00000863519d },
            { 39100.0d, 0.00000485858d },
            { 39200.0d, 0.00000215988d },
            { 39300.0d, 0.000000540061d },
            { 39400.0d, 0d },

        }; 
    }
}
    