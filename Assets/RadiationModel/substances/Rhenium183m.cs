using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium183m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium183m";
        public override double halfLife { get; } = 0.00104d;
        public override double atomicWeight { get; } = 182.95287d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium183()), new(0.16974d, new GammaParticle(114480.0, 0.01083)), new(0.31734d, new GammaParticle(145350.0, 0.00853)), new(0.34686d, new GammaParticle(175300.0, 0.00707)), new(0.738d, new GammaParticle(193900.0, 0.00639)), new(0.3321d, new GammaParticle(203900.0, 0.00608)), new(0.28782d, new GammaParticle(231600.0, 0.00535)), new(0.35424d, new GammaParticle(257400.0, 0.00482)), new(0.053874000000000005d, new GammaParticle(259900.0, 0.00477)), new(0.1476d, new GammaParticle(282300.0, 0.00439)), new(0.32472d, new GammaParticle(304200.0, 0.00408)), new(0.08856d, new GammaParticle(321100.0, 0.00386)), new(0.16974d, new GammaParticle(379100.0, 0.00327)), new(0.21402000000000002d, new GammaParticle(435500.0, 0.00285)), new(0.31734d, new GammaParticle(487900.0, 0.00254)), new(0.23616d, new GammaParticle(538100.0, 0.0023)), new(0.5904d, new GammaParticle(584900.0, 0.00212)), new(0.563507038744479d, new GammaParticle(10063.0, 0.12321)), new(0.5028298908728798d, new GammaParticle(59718.0, 0.02076)), new(0.869947908084567d, new GammaParticle(61141.0, 0.02028)), new(0.2891755896002767d, new GammaParticle(69395.0, 0.01787)), new(0.36927722791955325d, new GammaParticle(70206.0, 0.01766)), new(0.08010163831927664d, new GammaParticle(71195.0, 0.01741)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    