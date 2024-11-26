using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium109m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium109m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 108.90505d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium109()), new(0.09699999999999999d, new GammaParticle(59900.0, 0.0207)), new(0.0511442208d, new GammaParticle(3388.0, 0.36595)), new(0.13181765368960352d, new GammaParticle(22983.0, 0.05395)), new(0.24791734754486275d, new GammaParticle(23173.0, 0.0535)), new(0.06910405986931786d, new GammaParticle(26184.0, 0.04735)), new(0.0816809987655337d, new GammaParticle(26381.0, 0.047)), new(0.01257693889621585d, new GammaParticle(26641.0, 0.04654)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    