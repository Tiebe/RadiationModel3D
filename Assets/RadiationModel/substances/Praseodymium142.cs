using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium142";
        public override double halfLife { get; } = 68832.0d;
        public override double atomicWeight { get; } = 141.91005d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.999836d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium142() }, { 1.0d, new BetaParticle(-1, 1081849.99999) }, { 0.00023d, new GammaParticle(508800.0, 0.00244) }, { 0.037000000000000005d, new GammaParticle(1575600.0, 0.00079) } } },
            { 0.000164d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium142() }, { 2.2100000000000002e-05d, new GammaParticle(642000.0, 0.00193) }, { 1.75467441e-05d, new GammaParticle(5410.0, 0.22918) }, { 3.411373493557531e-05d, new GammaParticle(34279.0, 0.03617) }, { 6.247936801387419e-05d, new GammaParticle(34720.0, 0.03571) }, { 1.8817938636802645e-05d, new GammaParticle(39366.0, 0.0315) }, { 2.3597695050550515e-05d, new GammaParticle(39753.0, 0.03119) }, { 4.779756413747871e-06d, new GammaParticle(40229.0, 0.03082) } } },

        };
    }
}
    