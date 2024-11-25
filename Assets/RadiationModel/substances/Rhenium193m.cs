using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium193m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium193m";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 192.96771d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    