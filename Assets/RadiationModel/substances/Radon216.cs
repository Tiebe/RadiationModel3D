using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon216 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon216";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 216.00027d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium212() }, { 1.0d, new AlphaParticle(9219402.09) } } },

        };
    }
}
    