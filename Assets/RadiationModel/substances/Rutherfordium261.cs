using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium261 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium261";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 261.10877d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    