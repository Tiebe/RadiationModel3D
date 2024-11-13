
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium258p : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium258p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 258.10201d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    