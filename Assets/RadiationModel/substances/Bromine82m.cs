using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine82m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine82m";
        public override double halfLife { get; } = 367.8d;
        public override double atomicWeight { get; } = 81.91685d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.976d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine82() }, { 0.0025d, new GammaParticle(45949.0, 0.02698) }, { 0.0187602074d, new GammaParticle(1535.0, 0.80771) }, { 0.11511507723491271d, new GammaParticle(11879.0, 0.10437) }, { 0.22218698559141614d, new GammaParticle(11925.0, 0.10397) }, { 0.05269953320986924d, new GammaParticle(13345.0, 0.09291) }, { 0.056767937173671144d, new GammaParticle(13377.0, 0.09268) }, { 0.004068403963801905d, new GammaParticle(13469.0, 0.09205) } } },
            { 0.024d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton82() }, { 1.0d, new BetaParticle(-1, 1569497.5) }, { 2e-05d, new GammaParticle(619090.0, 0.002) }, { 0.00034d, new GammaParticle(698370.0, 0.00178) }, { 1.76e-05d, new GammaParticle(711200.0, 0.00174) }, { 3e-07d, new GammaParticle(735600.0, 0.00169) }, { 0.0026d, new GammaParticle(776520.0, 0.0016) }, { 2e-05d, new GammaParticle(1072990.0, 0.00116) }, { 4.4e-06d, new GammaParticle(1081290.0, 0.00115) }, { 3.6000000000000003e-06d, new GammaParticle(1168500.0, 0.00106) }, { 5.2e-08d, new GammaParticle(1173400.0, 0.00106) }, { 3.9e-05d, new GammaParticle(1180270.0, 0.00105) }, { 2.5999999999999997e-06d, new GammaParticle(1180950.0, 0.00105) }, { 1.11e-05d, new GammaParticle(1317440.0, 0.00094) }, { 5e-07d, new GammaParticle(1395100.0, 0.00089) }, { 0.0002d, new GammaParticle(1474880.0, 0.00084) }, { 2.9e-06d, new GammaParticle(1703190.0, 0.00073) }, { 8.000000000000001e-07d, new GammaParticle(1771000.0, 0.0007) }, { 4.1e-06d, new GammaParticle(1879500.0, 0.00066) }, { 1.66e-05d, new GammaParticle(1956750.0, 0.00063) }, { 2.4e-06d, new GammaParticle(2479600.0, 0.0005) }, { 7.3e-07d, new GammaParticle(2656000.0, 0.00047) } } },

        };
    }
}
    