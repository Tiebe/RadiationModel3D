
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium249 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium249";
        public override double halfLife { get; } = 25.6d;
        public override double atomicWeight { get; } = 249.08286d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.75d, new List<RadioactiveSubstance> { new AlphaParticle(), new Einsteinium245() } },

        };
    }
}
    
    