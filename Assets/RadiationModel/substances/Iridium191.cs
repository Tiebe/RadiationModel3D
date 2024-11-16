using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium191 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium191";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 190.96059d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    