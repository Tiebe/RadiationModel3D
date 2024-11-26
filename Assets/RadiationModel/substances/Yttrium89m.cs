using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium89m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium89m";
        public override double halfLife { get; } = 15.663d;
        public override double atomicWeight { get; } = 88.90681d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Yttrium89()), new(0.9915999999999999d, new GammaParticle(908960.0, 0.00136)), new(0.0002561335393892d, new GammaParticle(2027.0, 0.61166)), new(0.0015222198793617464d, new GammaParticle(14883.0, 0.08331)), new(0.0029189259431672988d, new GammaParticle(14958.0, 0.08289)), new(0.0007329061383751799d, new GammaParticle(16803.0, 0.07379)), new(0.0008340471854709547d, new GammaParticle(16880.0, 0.07345)), new(0.00010114104709577483d, new GammaParticle(17011.0, 0.07288)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    