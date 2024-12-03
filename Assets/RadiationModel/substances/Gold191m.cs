using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold191m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold191m";
        public override double halfLife { get; } = 0.92d;
        public override double atomicWeight { get; } = 190.964d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold191()), new(8.4e-08d, new GammaParticle(13700.0, 0.0905)), new(0.131d, new GammaParticle(241000.0, 0.00514)), new(0.615d, new GammaParticle(253000.0, 0.0049)), new(0.2377442255104d, new GammaParticle(11419.0, 0.10858)), new(0.05191676093822841d, new GammaParticle(66991.0, 0.01851)), new(0.08838399887338852d, new GammaParticle(68806.0, 0.01802)), new(0.029823435367248293d, new GammaParticle(78048.0, 0.01589)), new(0.03844240818838304d, new GammaParticle(78983.0, 0.0157)), new(0.008618972821134756d, new GammaParticle(80133.0, 0.01547)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    