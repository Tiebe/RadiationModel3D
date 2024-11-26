using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron55 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron55";
        public override double halfLife { get; } = 86592204.87428d;
        public override double atomicWeight { get; } = 54.93829d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Manganese55()), new(1.2800000000000001e-09d, new GammaParticle(126000.0, 0.00984)), new(0.006605521d, new GammaParticle(660.0, 1.87855)), new(0.08445882407206723d, new GammaParticle(5888.0, 0.21057)), new(0.16563801543845308d, new GammaParticle(5899.0, 0.21018)), new(0.03398816048947971d, new GammaParticle(6512.0, 0.19039)), new(0.03398816048947971d, new GammaParticle(6512.0, 0.19039)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    