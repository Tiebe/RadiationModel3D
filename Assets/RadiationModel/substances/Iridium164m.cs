using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium164m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium164m";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 163.99225d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.04d, new List<RadioactiveSubstance> { new AlphaParticle(8257002.09), new Rhenium160() } },

        };
    }
}
    
    