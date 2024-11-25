using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium81m : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium81m";
        public override double halfLife { get; } = 3436.8d;
        public override double atomicWeight { get; } = 80.9181d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99949d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium81() }, { 0.128d, new GammaParticle(103010.0, 0.01204) }, { 0.022700608d, new GammaParticle(1426.0, 0.86945) }, { 0.16013045072549306d, new GammaParticle(11183.0, 0.11087) }, { 0.3104506605767605d, new GammaParticle(11223.0, 0.11047) }, { 0.07244507545705968d, new GammaParticle(12546.0, 0.09882) }, { 0.07651648869774644d, new GammaParticle(12571.0, 0.09863) }, { 0.004071413240686755d, new GammaParticle(12652.0, 0.098) } } },
            { 0.0005099999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine81() }, { 1.0d, new BetaParticle(-1, 845550.0) }, { 3.2e-05d, new GammaParticle(201000.0, 0.00617) }, { 0.00048d, new GammaParticle(260100.0, 0.00477) }, { 0.0005d, new GammaParticle(275930.0, 0.00449) }, { 7e-07d, new GammaParticle(491300.0, 0.00252) }, { 5e-06d, new GammaParticle(767100.0, 0.00162) }, { 5.522485331008e-07d, new GammaParticle(1535.0, 0.80771) }, { 4.011988470387311e-06d, new GammaParticle(11879.0, 0.10437) }, { 7.74365657283789e-06d, new GammaParticle(11925.0, 0.10397) }, { 1.8366831236305248e-06d, new GammaParticle(13345.0, 0.09291) }, { 1.9784750607748013e-06d, new GammaParticle(13377.0, 0.09268) }, { 1.417919371442765e-07d, new GammaParticle(13469.0, 0.09205) } } },

        };
    }
}
    