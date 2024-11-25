using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum180m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum180m";
        public override double halfLife { get; } = 2.240541744196032e+23d;
        public override double atomicWeight { get; } = 179.94755d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    