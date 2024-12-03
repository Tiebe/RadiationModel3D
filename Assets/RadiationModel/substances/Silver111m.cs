using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver111m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver111m";
        public override double halfLife { get; } = 64.8d;
        public override double atomicWeight { get; } = 110.90536d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.993d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver111()), new(0.005350000000000001d, new GammaParticle(59770.0, 0.02074)), new(0.04886054206d, new GammaParticle(3218.0, 0.38528)), new(0.05465042811290698d, new GammaParticle(21990.0, 0.05638)), new(0.10301682961905181d, new GammaParticle(22163.0, 0.05594)), new(0.028538579444668862d, new GammaParticle(25030.0, 0.04953)), new(0.03350429226804124d, new GammaParticle(25211.0, 0.04918)), new(0.004965712823372382d, new GammaParticle(25454.0, 0.04871)) } },
            { 0.006999999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium111()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(7.4700000000000005e-06d, new GammaParticle(96750.0, 0.01281)), new(0.00126d, new GammaParticle(171280.0, 0.00724)), new(8.46e-06d, new GammaParticle(203290.0, 0.0061)), new(0.00522d, new GammaParticle(245400.0, 0.00505)), new(7.65e-05d, new GammaParticle(278300.0, 0.00446)), new(0.000144d, new GammaParticle(336160.0, 0.00369)), new(0.00043200000000000004d, new GammaParticle(342130.0, 0.00362)), new(0.00035999999999999997d, new GammaParticle(374750.0, 0.00331)), new(0.000378d, new GammaParticle(410770.0, 0.00302)), new(0.00045d, new GammaParticle(506900.0, 0.00245)), new(0.00126d, new GammaParticle(620100.0, 0.002)), new(0.00045d, new GammaParticle(752700.0, 0.00165)), new(2.8843741907424e-05d, new GammaParticle(3388.0, 0.36595)), new(9.98774760842154e-05d, new GammaParticle(22983.0, 0.05395)), new(0.00018784554463835884d, new GammaParticle(23173.0, 0.0535)), new(5.235974767971719e-05d, new GammaParticle(26184.0, 0.04735)), new(6.188922175742571e-05d, new GammaParticle(26381.0, 0.047)), new(9.529474077708529e-06d, new GammaParticle(26641.0, 0.04654)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    