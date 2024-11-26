using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium237m : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium237m";
        public override double halfLife { get; } = 0.18d;
        public override double atomicWeight { get; } = 237.04856d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Plutonium237()), new(0.019d, new GammaParticle(145542.0, 0.00852)), new(0.35955689640000005d, new GammaParticle(17604.0, 0.07043)), new(0.0011424588426978519d, new GammaParticle(99533.0, 0.01246)), new(0.0018085465295201075d, new GammaParticle(103741.0, 0.01195)), new(0.000663811898873082d, new GammaParticle(117130.0, 0.01059)), new(0.0008941546277820415d, new GammaParticle(118619.0, 0.01045)), new(0.00023034272890895945d, new GammaParticle(120544.0, 0.01029)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    