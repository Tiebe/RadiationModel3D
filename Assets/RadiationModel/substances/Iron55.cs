using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron55 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron55";
        public override double halfLife { get; } = 86977271.1024d;
        public override double atomicWeight { get; } = 54.93829d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Manganese55() } },

        };
    }
}
    
    