using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine30 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine30";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 30.05256d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    