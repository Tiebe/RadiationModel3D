using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten168 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten168";
        public override double halfLife { get; } = 50.9d;
        public override double atomicWeight { get; } = 167.95181d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium168() }, { 1.0d, new BetaParticle(1, 5234000.0) }, { 0.01014d, new GammaParticle(37100.0, 0.03342) }, { 0.015600000000000001d, new GammaParticle(145500.0, 0.00852) }, { 0.013260000000000001d, new GammaParticle(156600.0, 0.00792) }, { 0.010920000000000001d, new GammaParticle(173900.0, 0.00713) }, { 0.78d, new GammaParticle(178500.0, 0.00695) }, { 0.013260000000000001d, new GammaParticle(181800.0, 0.00682) }, { 0.014039999999999999d, new GammaParticle(352200.0, 0.00352) }, { 0.010920000000000001d, new GammaParticle(573100.0, 0.00216) }, { 0.43200000000000005d, new GammaParticle(511000.0, 0.00243) }, { 0.171825740976d, new GammaParticle(9424.0, 0.13156) }, { 0.17488628628727595d, new GammaParticle(56280.0, 0.02203) }, { 0.30489240984532073d, new GammaParticle(57535.0, 0.02155) }, { 0.10086685973811285d, new GammaParticle(65315.0, 0.01898) }, { 0.12810091186740333d, new GammaParticle(66067.0, 0.01877) }, { 0.02723405212929047d, new GammaParticle(66981.0, 0.01851) } } },
            { 3.2e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium164() }, { 1.0d, new AlphaParticle(5522002.09) } } },

        };
    }
}
    