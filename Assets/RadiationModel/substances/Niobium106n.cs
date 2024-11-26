using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium106n : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium106n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 105.92915d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium106() }, { 0.336d, new GammaParticle(63500.0, 0.01953) }, { 0.5628d, new GammaParticle(94700.0, 0.01309) }, { 0.336d, new GammaParticle(108100.0, 0.01147) }, { 0.1344d, new GammaParticle(147500.0, 0.00841) }, { 0.5544d, new GammaParticle(202100.0, 0.00613) }, { 0.84d, new GammaParticle(204900.0, 0.00605) }, { 0.007012603759392d, new GammaParticle(2299.0, 0.5393) }, { 0.03716594259109138d, new GammaParticle(16521.0, 0.07505) }, { 0.07098155575074747d, new GammaParticle(16615.0, 0.07462) }, { 0.018366266457531418d, new GammaParticle(18694.0, 0.06632) }, { 0.021121206426161127d, new GammaParticle(18795.0, 0.06597) }, { 0.0027549399686297125d, new GammaParticle(18951.0, 0.06542) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    