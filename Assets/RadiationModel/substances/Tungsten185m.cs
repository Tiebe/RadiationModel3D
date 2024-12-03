using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tungsten185m : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten185m";
        public override double halfLife { get; } = 100.2d;
        public override double atomicWeight { get; } = 184.95363d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten185()), new(8.1e-10d, new GammaParticle(9530.0, 0.1301)), new(0.0016887d, new GammaParticle(23540.0, 0.05267)), new(7.794e-06d, new GammaParticle(23540.0, 0.05267)), new(0.0007361d, new GammaParticle(42290.0, 0.02932)), new(0.058022d, new GammaParticle(65860.0, 0.01883)), new(0.00026846d, new GammaParticle(93300.0, 0.01329)), new(0.00105219d, new GammaParticle(94590.0, 0.01311)), new(0.0040701999999999995d, new GammaParticle(107850.0, 0.0115)), new(0.0010175499999999999d, new GammaParticle(122050.0, 0.01016)), new(0.0433d, new GammaParticle(131550.0, 0.00942)), new(0.0058888d, new GammaParticle(164330.0, 0.00754)), new(0.032648199999999995d, new GammaParticle(173680.0, 0.00714)), new(0.008140399999999999d, new GammaParticle(187880.0, 0.0066)), new(0.437199619896095d, new GammaParticle(9740.0, 0.12729)), new(0.023701697937661054d, new GammaParticle(57983.0, 0.02138)), new(0.04117022396675535d, new GammaParticle(59320.0, 0.0209)), new(0.013646526742844264d, new GammaParticle(67335.0, 0.01841)), new(0.017385675070383595d, new GammaParticle(68117.0, 0.0182)), new(0.0037391483275393284d, new GammaParticle(69068.0, 0.01795)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    