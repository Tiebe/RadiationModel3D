using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium115n : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium115n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 114.9122d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium115() }, { 0.8420000000000001d, new GammaParticle(280300.0, 0.00442) }, { 0.014351322492000001d, new GammaParticle(4135.0, 0.29984) }, { 0.03987229219870405d, new GammaParticle(27202.0, 0.04558) }, { 0.07425007858231666d, new GammaParticle(27473.0, 0.04513) }, { 0.021249079062431626d, new GammaParticle(31093.0, 0.03988) }, { 0.025860129218979292d, new GammaParticle(31359.0, 0.03954) }, { 0.004611050156547663d, new GammaParticle(31698.0, 0.03911) } } },

        };
    }
}
    