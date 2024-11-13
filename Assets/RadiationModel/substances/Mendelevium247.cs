
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium247 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium247";
        public override double halfLife { get; } = 1.19d;
        public override double atomicWeight { get; } = 247.08152d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Einsteinium243() } },

            { 0.001d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    