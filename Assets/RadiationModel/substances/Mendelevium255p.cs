using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium255p : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium255p";
        public override double halfLife { get; } = 1620.0d;
        public override double atomicWeight { get; } = 255.09109d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.93d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fermium255() }, { 0.023d, new GammaParticle(169600.0, 0.00731) }, { 0.033d, new GammaParticle(231400.0, 0.00536) }, { 0.37625639977799996d, new GammaParticle(20618.0, 0.06013) }, { 0.18075198795296207d, new GammaParticle(115320.0, 0.01075) }, { 0.2764637319561977d, new GammaParticle(121090.0, 0.01024) }, { 0.10791635741973549d, new GammaParticle(136318.0, 0.0091) }, { 0.14676624609084027d, new GammaParticle(138067.0, 0.00898) }, { 0.038849888671104775d, new GammaParticle(140406.0, 0.00883) } } },
            { 0.07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium251() }, { 1.0d, new AlphaParticle(8935002.09) }, { 0.053d, new GammaParticle(405350.0, 0.00306) }, { 0.07d, new GammaParticle(452900.0, 0.00274) } } },

        };
    }
}
    