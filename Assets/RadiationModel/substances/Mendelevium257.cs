
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium257 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium257";
        public override double halfLife { get; } = 19872.0d;
        public override double atomicWeight { get; } = 257.09554d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.85d, new List<RadioactiveSubstance> { new Fermium257() } },

            { 0.15d, new List<RadioactiveSubstance> { new AlphaParticle(), new Einsteinium253() } },

        };
    }
}
    
    