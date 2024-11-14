using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nihonium287 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium287";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 287.18407d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    