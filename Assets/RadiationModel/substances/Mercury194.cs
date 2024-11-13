
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury194 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury194";
        public override double halfLife { get; } = 14105957544.0d;
        public override double atomicWeight { get; } = 193.96545d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Gold194() } },

        };
    }
}
    
    