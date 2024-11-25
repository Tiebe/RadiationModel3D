using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium169";
        public override double halfLife { get; } = 3.43d;
        public override double atomicWeight { get; } = 168.96702d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.863d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten169() }, { 1.0d, new BetaParticle(1, 7097500.0) } } },
            { 0.13699999999999998d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten165() }, { 1.0d, new AlphaParticle(6735002.09) } } },

        };
    }
}
    