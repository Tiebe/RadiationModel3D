
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum191 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum191";
        public override double halfLife { get; } = 244512.0d;
        public override double atomicWeight { get; } = 190.96168d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Iridium191() } },

        };
    }
}
    
    