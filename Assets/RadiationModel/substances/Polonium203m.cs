using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium203m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium203m";
        public override double halfLife { get; } = 45.0d;
        public override double atomicWeight { get; } = 202.98211d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium203() }, { 9e-13d, new GammaParticle(2300.0, 0.53906) }, { 0.0017399999999999998d, new GammaParticle(62600.0, 0.01981) }, { 0.035699999999999996d, new GammaParticle(577000.0, 0.00215) }, { 0.30329999999999996d, new GammaParticle(639400.0, 0.00194) }, { 0.3446d, new GammaParticle(641500.0, 0.00193) }, { 0.110803700758049d, new GammaParticle(13292.0, 0.09328) }, { 0.060592490361237775d, new GammaParticle(76862.0, 0.01613) }, { 0.10090339777058746d, new GammaParticle(79290.0, 0.01564) }, { 0.034738245959706114d, new GammaParticle(89837.0, 0.0138) }, { 0.04554184045317472d, new GammaParticle(90941.0, 0.01363) }, { 0.010803594493468602d, new GammaParticle(92315.0, 0.01343) } } },

        };
    }
}
    