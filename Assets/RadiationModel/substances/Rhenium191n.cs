using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium191n : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium191n";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 190.96484d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    