using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon230 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon230";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 230.04527d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    