using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium184 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium184";
        public override double halfLife { get; } = 14832.0d;
        public override double atomicWeight { get; } = 183.95545d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum184() }, { 1.0d, new BetaParticle(-1, 669500.0) }, { 0.09405d, new GammaParticle(41400.0, 0.02995) }, { 0.05795d, new GammaParticle(43900.0, 0.02824) }, { 0.011399999999999999d, new GammaParticle(47900.0, 0.02588) }, { 0.456d, new GammaParticle(139100.0, 0.00891) }, { 0.1406d, new GammaParticle(181000.0, 0.00685) }, { 0.3515d, new GammaParticle(344900.0, 0.00359) }, { 0.6355112304316d, new GammaParticle(9424.0, 0.13156) }, { 0.08247123680451202d, new GammaParticle(56280.0, 0.02203) }, { 0.14377830684189682d, new GammaParticle(57535.0, 0.02155) }, { 0.04756584893983556d, new GammaParticle(65315.0, 0.01898) }, { 0.06040862815359116d, new GammaParticle(66067.0, 0.01877) }, { 0.012842779213755602d, new GammaParticle(66981.0, 0.01851) } } },

        };
    }
}
    