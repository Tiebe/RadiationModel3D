using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zirconium93 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium93";
        public override double halfLife { get; } = 50806650819093.12d;
        public override double atomicWeight { get; } = 92.90647d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium93()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(4.2999999999999995e-06d, new GammaParticle(30770.0, 0.04029)), new(0.021275126935d, new GammaParticle(2299.0, 0.5393)), new(0.024116039266597188d, new GammaParticle(16521.0, 0.07505)), new(0.046058134580972465d, new GammaParticle(16615.0, 0.07462)), new(0.011917405349939436d, new GammaParticle(18694.0, 0.06632)), new(0.013705016152430352d, new GammaParticle(18795.0, 0.06597)), new(0.0017876108024909153d, new GammaParticle(18951.0, 0.06542)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0104153d },
            { 200.0d, 0.0141944d },
            { 400.0d, 0.0169901d },
            { 600.0d, 0.0188026d },
            { 800.0d, 0.020073d },
            { 1000.0d, 0.0210067d },
            { 1300.0d, 0.0220354d },
            { 1600.0d, 0.022775d },
            { 1900.0d, 0.0233388d },
            { 2200.0d, 0.023781d },
            { 2500.0d, 0.0241399d },
            { 2800.0d, 0.0244366d },
            { 3100.0d, 0.024687d },
            { 3400.0d, 0.0249009d },
            { 3700.0d, 0.025086d },
            { 4000.0d, 0.0252472d },
            { 4300.0d, 0.0253888d },
            { 4600.0d, 0.0255136d },
            { 4900.0d, 0.0256238d },
            { 5200.0d, 0.0257214d },
            { 5500.0d, 0.0258078d },
            { 5800.0d, 0.0258839d },
            { 6100.0d, 0.025951d },
            { 6400.0d, 0.0260096d },
            { 6700.0d, 0.0260603d },
            { 7000.0d, 0.0261038d },
            { 7300.0d, 0.0261405d },
            { 7600.0d, 0.0261707d },
            { 7900.0d, 0.0261948d },
            { 8200.0d, 0.0262131d },
            { 8500.0d, 0.0262259d },
            { 8800.0d, 0.0262332d },
            { 9100.0d, 0.0262355d },
            { 9400.0d, 0.0262328d },
            { 9700.0d, 0.0262253d },
            { 10000.0d, 0.0262131d },
            { 10300.0d, 0.0261964d },
            { 10600.0d, 0.0261753d },
            { 10900.0d, 0.0261498d },
            { 11200.0d, 0.0261202d },
            { 11500.0d, 0.0260864d },
            { 11800.0d, 0.0260486d },
            { 12100.0d, 0.0260069d },
            { 12400.0d, 0.0259613d },
            { 12700.0d, 0.0259119d },
            { 13000.0d, 0.0258588d },
            { 13300.0d, 0.0258021d },
            { 13600.0d, 0.0257417d },
            { 13900.0d, 0.0256778d },
            { 14200.0d, 0.0256105d },
            { 14500.0d, 0.0255396d },
            { 14800.0d, 0.0254655d },
            { 15100.0d, 0.025388d },
            { 15400.0d, 0.0253073d },
            { 15700.0d, 0.0252233d },
            { 16000.0d, 0.0251362d },
            { 16300.0d, 0.0250459d },
            { 16600.0d, 0.0249525d },
            { 16900.0d, 0.0248561d },
            { 17200.0d, 0.0247568d },
            { 17500.0d, 0.0246544d },
            { 17800.0d, 0.0245492d },
            { 18100.0d, 0.0244411d },
            { 18400.0d, 0.0243303d },
            { 18700.0d, 0.0242165d },
            { 19000.0d, 0.0241001d },
            { 19300.0d, 0.023981d },
            { 19600.0d, 0.0238592d },
            { 19900.0d, 0.0237347d },
            { 20200.0d, 0.0236078d },
            { 20500.0d, 0.0234782d },
            { 20800.0d, 0.0233463d },
            { 21100.0d, 0.0232117d },
            { 21400.0d, 0.0230748d },
            { 21700.0d, 0.0229355d },
            { 22000.0d, 0.0227939d },
            { 22300.0d, 0.02265d },
            { 22600.0d, 0.0225037d },
            { 22900.0d, 0.0223553d },
            { 23200.0d, 0.0222047d },
            { 23500.0d, 0.0220519d },
            { 23800.0d, 0.0218971d },
            { 24100.0d, 0.0217401d },
            { 24400.0d, 0.0215811d },
            { 24700.0d, 0.0214202d },
            { 25000.0d, 0.0212573d },
            { 25300.0d, 0.0210924d },
            { 25600.0d, 0.0209258d },
            { 25900.0d, 0.0207572d },
            { 26200.0d, 0.0205869d },
            { 26500.0d, 0.0204148d },
            { 26800.0d, 0.0202411d },
            { 27100.0d, 0.0200657d },
            { 27400.0d, 0.0198886d },
            { 27700.0d, 0.01971d },
            { 28000.0d, 0.0195299d },
            { 28300.0d, 0.0193482d },
            { 28600.0d, 0.019165d },
            { 28900.0d, 0.0189805d },
            { 29200.0d, 0.0187945d },
            { 29500.0d, 0.0186073d },
            { 29800.0d, 0.0184188d },
            { 30100.0d, 0.018229d },
            { 30400.0d, 0.0180381d },
            { 30700.0d, 0.017846d },
            { 31000.0d, 0.0176528d },
            { 31300.0d, 0.0174585d },
            { 31600.0d, 0.0172632d },
            { 31900.0d, 0.017067d },
            { 32200.000000000004d, 0.0168698d },
            { 32500.0d, 0.0166718d },
            { 32800.0d, 0.0164728d },
            { 33100.0d, 0.0162731d },
            { 33400.0d, 0.0160728d },
            { 33700.0d, 0.0158716d },
            { 34000.0d, 0.0156698d },
            { 34300.0d, 0.0154675d },
            { 34600.0d, 0.0152646d },
            { 34900.0d, 0.0150612d },
            { 35200.0d, 0.0148574d },
            { 35500.0d, 0.0146531d },
            { 35800.0d, 0.0144485d },
            { 36100.0d, 0.0142437d },
            { 36400.0d, 0.0140385d },
            { 36700.0d, 0.0138331d },
            { 37000.0d, 0.0136277d },
            { 37300.0d, 0.0134221d },
            { 37600.0d, 0.0132165d },
            { 37900.0d, 0.0130108d },
            { 38200.0d, 0.0128053d },
            { 38500.0d, 0.0125998d },
            { 38800.0d, 0.0123946d },
            { 39100.0d, 0.0121895d },
            { 39400.0d, 0.0119848d },
            { 39700.0d, 0.0117803d },
            { 40000.0d, 0.0115763d },
            { 40300.0d, 0.0113727d },
            { 40600.0d, 0.0111696d },
            { 40900.0d, 0.010967d },
            { 41200.0d, 0.0107651d },
            { 41500.0d, 0.0105638d },
            { 41800.0d, 0.0103633d },
            { 42100.0d, 0.0101635d },
            { 42400.0d, 0.00996458d },
            { 42700.0d, 0.00976656d },
            { 43000.0d, 0.0095695d },
            { 43300.0d, 0.00937345d },
            { 43600.0d, 0.00917849d },
            { 43900.0d, 0.00898466d },
            { 44200.0d, 0.00879205d },
            { 44500.0d, 0.00860068d },
            { 44800.0d, 0.00841064d },
            { 45100.0d, 0.00822198d },
            { 45400.0d, 0.00803478d },
            { 45700.0d, 0.00784907d },
            { 46000.0d, 0.00766495d },
            { 46300.0d, 0.00748246d },
            { 46600.0d, 0.00730168d },
            { 46900.0d, 0.00712265d },
            { 47200.0d, 0.00694546d },
            { 47500.0d, 0.00677016d },
            { 47800.0d, 0.00659682d },
            { 48100.0d, 0.00642552d },
            { 48400.0d, 0.00625631d },
            { 48700.0d, 0.00608926d },
            { 49000.0d, 0.00592443d },
            { 49300.0d, 0.0057619d },
            { 49600.0d, 0.00560175d },
            { 49900.0d, 0.00544403d },
            { 50200.0d, 0.0052888d },
            { 50500.0d, 0.00513616d },
            { 50800.0d, 0.00498615d },
            { 51100.0d, 0.00483886d },
            { 51400.0d, 0.00469436d },
            { 51700.0d, 0.00455272d },
            { 52000.0d, 0.00441401d },
            { 52300.0d, 0.00427828d },
            { 52600.0d, 0.00414565d },
            { 52900.0d, 0.00401615d },
            { 53200.0d, 0.00388988d },
            { 53500.0d, 0.00376692d },
            { 53800.0d, 0.00364732d },
            { 54100.0d, 0.00353116d },
            { 54400.0d, 0.00341853d },
            { 54700.0d, 0.0033095d },
            { 55000.0d, 0.00320414d },
            { 55300.0d, 0.00310253d },
            { 55600.0d, 0.00300475d },
            { 55900.0d, 0.00291089d },
            { 56200.0d, 0.00282101d },
            { 56500.0d, 0.0027352d },
            { 56800.0d, 0.00265352d },
            { 57100.0d, 0.00257607d },
            { 57400.0d, 0.00250294d },
            { 57700.0d, 0.00243418d },
            { 58000.0d, 0.00236989d },
            { 58300.0d, 0.00231015d },
            { 58600.0d, 0.00225504d },
            { 58900.0d, 0.00220465d },
            { 59200.0d, 0.00215905d },
            { 59500.0d, 0.00211834d },
            { 59800.0d, 0.00208259d },
            { 60100.0d, 0.0020516d },
            { 60400.0d, 0.00202175d },
            { 60700.0d, 0.00199193d },
            { 61000.0d, 0.00196215d },
            { 61300.0d, 0.0019324d },
            { 61600.0d, 0.00190268d },
            { 61900.0d, 0.001873d },
            { 62200.0d, 0.00184337d },
            { 62500.0d, 0.0018138d },
            { 62800.0d, 0.00178428d },
            { 63100.0d, 0.00175482d },
            { 63400.0d, 0.00172542d },
            { 63700.0d, 0.00169609d },
            { 64000.0d, 0.00166684d },
            { 64300.0d, 0.00163766d },
            { 64599.99999999999d, 0.00160857d },
            { 64900.00000000001d, 0.00157956d },
            { 65200.0d, 0.00155065d },
            { 65500.0d, 0.00152184d },
            { 65800.0d, 0.00149312d },
            { 66100.0d, 0.00146451d },
            { 66400.0d, 0.00143601d },
            { 66700.0d, 0.00140762d },
            { 67000.0d, 0.00137936d },
            { 67300.0d, 0.00135123d },
            { 67600.0d, 0.00132322d },
            { 67900.0d, 0.00129534d },
            { 68200.0d, 0.00126761d },
            { 68500.0d, 0.00124002d },
            { 68800.0d, 0.00121259d },
            { 69100.0d, 0.0011853d },
            { 69400.0d, 0.00115819d },
            { 69700.0d, 0.00113123d },
            { 70000.0d, 0.00110444d },
            { 70300.0d, 0.00107784d },
            { 70600.0d, 0.00105141d },
            { 70900.0d, 0.00102517d },
            { 71200.0d, 0.000999118d },
            { 71500.0d, 0.000973268d },
            { 71800.0d, 0.000947619d },
            { 72100.0d, 0.000922177d },
            { 72400.0d, 0.00089695d },
            { 72700.0d, 0.000871941d },
            { 73000.0d, 0.000847156d },
            { 73300.0d, 0.0008226d },
            { 73600.0d, 0.000798281d },
            { 73900.0d, 0.000774203d },
            { 74200.0d, 0.000750371d },
            { 74500.0d, 0.000726792d },
            { 74800.0d, 0.000703472d },
            { 75100.0d, 0.000680414d },
            { 75400.0d, 0.000657627d },
            { 75700.0d, 0.000635115d },
            { 76000.0d, 0.000612885d },
            { 76300.0d, 0.000590942d },
            { 76600.0d, 0.000569292d },
            { 76900.0d, 0.000547941d },
            { 77200.0d, 0.000526896d },
            { 77500.0d, 0.000506162d },
            { 77800.0d, 0.000485744d },
            { 78100.0d, 0.000465651d },
            { 78400.0d, 0.000445887d },
            { 78700.0d, 0.000426459d },
            { 79000.0d, 0.000407373d },
            { 79300.0d, 0.000388634d },
            { 79600.0d, 0.000370251d },
            { 79900.0d, 0.000352228d },
            { 80200.0d, 0.000334572d },
            { 80500.0d, 0.00031729d },
            { 80800.0d, 0.000300388d },
            { 81100.0d, 0.000283872d },
            { 81400.0d, 0.000267749d },
            { 81700.0d, 0.000252026d },
            { 82000.0d, 0.000236709d },
            { 82300.0d, 0.000221804d },
            { 82600.0d, 0.000207319d },
            { 82900.0d, 0.00019326d },
            { 83200.0d, 0.000179634d },
            { 83500.0d, 0.000166447d },
            { 83800.0d, 0.000153706d },
            { 84100.0d, 0.000141418d },
            { 84400.0d, 0.000129591d },
            { 84700.0d, 0.000118231d },
            { 85000.0d, 0.000107343d },
            { 85300.0d, 0.0000969377d },
            { 85600.0d, 0.00008702d },
            { 85900.0d, 0.0000775968d },
            { 86200.0d, 0.0000686758d },
            { 86500.0d, 0.0000602638d },
            { 86800.0d, 0.0000523682d },
            { 87100.0d, 0.0000449961d },
            { 87400.0d, 0.0000381547d },
            { 87700.0d, 0.0000318514d },
            { 88000.0d, 0.0000260934d },
            { 88300.0d, 0.0000208881d },
            { 88600.0d, 0.0000162428d },
            { 88900.0d, 0.0000121651d },
            { 89200.0d, 0.00000866236d },
            { 89500.0d, 0.00000574198d },
            { 89800.0d, 0.00000341151d },
            { 90100.0d, 0.0000016785d },
            { 90400.0d, 0.000000550453d },
            { 90700.0d, 0.0000000346737d },
            { 90800.0d, 0d },

        }; 
    }
}
    