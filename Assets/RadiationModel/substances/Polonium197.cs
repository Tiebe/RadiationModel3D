using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium197 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium197";
        public override double halfLife { get; } = 84.0d;
        public override double atomicWeight { get; } = 196.98562d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.56d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead197() }, { 1.0d, new BetaParticle(1, 5676000.0) } } },
            { 0.44d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead193() }, { 1.0d, new AlphaParticle(7433002.09) } } },

        };
    }
}
    