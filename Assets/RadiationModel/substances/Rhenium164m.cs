using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium164m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium164m";
        public override double halfLife { get; } = 0.89d;
        public override double atomicWeight { get; } = 163.97046d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.03d, new List<RadioactiveSubstance> { new AlphaParticle(6895047.4), new Tantalum160() } },

        };
    }
}
    
    