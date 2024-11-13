
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum191 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum191";
        public override double halfLife { get; } = 0.46d;
        public override double atomicWeight { get; } = 190.97153d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    