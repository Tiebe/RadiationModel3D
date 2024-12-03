using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead195m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead195m";
        public override double halfLife { get; } = 900.0d;
        public override double atomicWeight { get; } = 194.97473d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury195()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.006320599999999999d, new GammaParticle(98970.0, 0.01253)), new(0.000442d, new GammaParticle(236600.0, 0.00524)), new(0.010166d, new GammaParticle(294200.0, 0.00421)), new(0.0091494d, new GammaParticle(305670.0, 0.00406)), new(0.069836d, new GammaParticle(313220.0, 0.00396)), new(0.0066742d, new GammaParticle(325850.0, 0.0038)), new(0.91494d, new GammaParticle(383640.0, 0.00323)), new(0.007514d, new GammaParticle(392800.0, 0.00316)), new(0.442d, new GammaParticle(394210.0, 0.00315)), new(0.0063648d, new GammaParticle(419810.0, 0.00295)), new(0.045526d, new GammaParticle(428440.0, 0.00289)), new(0.0082212d, new GammaParticle(442740.0, 0.0028)), new(0.003978d, new GammaParticle(466400.0, 0.00266)), new(0.005304d, new GammaParticle(534110.0, 0.00232)), new(0.01768d, new GammaParticle(534110.0, 0.00232)), new(0.013304199999999999d, new GammaParticle(539500.0, 0.0023)), new(0.004862d, new GammaParticle(549000.0, 0.00226)), new(0.083538d, new GammaParticle(607640.0, 0.00204)), new(0.032708d, new GammaParticle(630580.0, 0.00197)), new(0.032708d, new GammaParticle(630580.0, 0.00197)), new(0.007072d, new GammaParticle(672600.0, 0.00184)), new(0.029171999999999997d, new GammaParticle(691170.0, 0.00179)), new(0.140998d, new GammaParticle(707670.0, 0.00175)), new(0.0056576000000000005d, new GammaParticle(717430.0, 0.00173)), new(0.015912d, new GammaParticle(734430.0, 0.00169)), new(0.0038454d, new GammaParticle(739470.0, 0.00168)), new(0.042432d, new GammaParticle(742190.0, 0.00167)), new(0.015028d, new GammaParticle(748800.0, 0.00166)), new(0.008398d, new GammaParticle(754730.0, 0.00164)), new(0.020332d, new GammaParticle(801260.0, 0.00155)), new(0.024752d, new GammaParticle(815310.0, 0.00152)), new(0.006188d, new GammaParticle(821300.0, 0.00151)), new(0.006188d, new GammaParticle(843200.0, 0.00147)), new(0.007514d, new GammaParticle(847100.0, 0.00146)), new(0.029613999999999998d, new GammaParticle(848660.0, 0.00146)), new(0.009282d, new GammaParticle(877900.0, 0.00141)), new(0.24309999999999998d, new GammaParticle(878400.0, 0.00141)), new(0.029613999999999998d, new GammaParticle(889900.0, 0.00139)), new(0.0156026d, new GammaParticle(912740.0, 0.00136)), new(0.039338000000000005d, new GammaParticle(928020.0, 0.00134)), new(0.008530600000000001d, new GammaParticle(937860.0, 0.00132)), new(0.01547d, new GammaParticle(979070.0, 0.00127)), new(0.013834599999999999d, new GammaParticle(1000920.0, 0.00124)), new(0.063206d, new GammaParticle(1067880.0, 0.00116)), new(0.0081328d, new GammaParticle(1133730.0, 0.00109)), new(0.015028d, new GammaParticle(1161600.0, 0.00107)), new(0.0033592d, new GammaParticle(1242240.0, 0.001)), new(0.012376d, new GammaParticle(1391000.0, 0.00089)), new(0.0098566d, new GammaParticle(1630460.0, 0.00076)), new(0.0116688d, new GammaParticle(1929840.0, 0.00064)), new(0.23108d, new GammaParticle(511000.0, 0.00243)), new(0.59d, new GammaParticle(12148.0, 0.10206)), new(0.24600000000000002d, new GammaParticle(70832.0, 0.0175)), new(0.41600000000000004d, new GammaParticle(72874.0, 0.01701)), new(0.141d, new GammaParticle(82629.0, 0.015)), new(0.183d, new GammaParticle(83631.0, 0.01483)), new(0.042d, new GammaParticle(84866.0, 0.01461)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    