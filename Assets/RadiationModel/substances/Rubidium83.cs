using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rubidium83 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium83";
        public override double halfLife { get; } = 7447680.0d;
        public override double atomicWeight { get; } = 82.91511d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Krypton83()), new(0.058557d, new GammaParticle(9405.7, 0.13182)), new(0.0003576d, new GammaParticle(32151.6, 0.03856)), new(0.00014304d, new GammaParticle(119320.0, 0.01039)), new(1.341e-05d, new GammaParticle(128550.0, 0.00964)), new(4.917e-06d, new GammaParticle(237190.0, 0.00523)), new(0.447d, new GammaParticle(520399.1, 0.00238)), new(0.293232d, new GammaParticle(529594.5, 0.00234)), new(0.159579d, new GammaParticle(552551.2, 0.00224)), new(8.493e-05d, new GammaParticle(562170.0, 0.00221)), new(0.0008493000000000001d, new GammaParticle(648970.0, 0.00191)), new(0.00031289999999999996d, new GammaParticle(681180.0, 0.00182)), new(0.006570899999999999d, new GammaParticle(790150.0, 0.00157)), new(0.0023691000000000003d, new GammaParticle(799370.0, 0.00155)), new(0.055d, new GammaParticle(1648.0, 0.75233)), new(0.19899999999999998d, new GammaParticle(12596.0, 0.09843)), new(0.38299999999999995d, new GammaParticle(12649.0, 0.09802)), new(0.092d, new GammaParticle(14169.0, 0.0875)), new(0.10099999999999999d, new GammaParticle(14209.0, 0.08726)), new(0.009300000000000001d, new GammaParticle(14313.0, 0.08662)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    