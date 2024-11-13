
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine20i : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine20i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 20.00698d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    