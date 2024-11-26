using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium111 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium111";
        public override double halfLife { get; } = 242326.08d;
        public override double atomicWeight { get; } = 110.90511d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium111()), new(3e-05d, new GammaParticle(150810.0, 0.00822)), new(0.9065000000000001d, new GammaParticle(171280.0, 0.00724)), new(0.9409000000000001d, new GammaParticle(245350.0, 0.00505)), new(0.067631966971776d, new GammaParticle(3388.0, 0.36595)), new(0.2356763885408537d, new GammaParticle(22983.0, 0.05395)), new(0.4432506837330331d, new GammaParticle(23173.0, 0.0535)), new(0.12355094183258297d, new GammaParticle(26184.0, 0.04735)), new(0.14603721324611305d, new GammaParticle(26381.0, 0.047)), new(0.0224862714135301d, new GammaParticle(26641.0, 0.04654)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    