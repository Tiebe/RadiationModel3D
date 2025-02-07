using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Praseodymium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium154";
        public override double halfLife { get; } = 2.3d;
        public override double atomicWeight { get; } = 153.93788d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium154()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.10944000000000001d, new GammaParticle(70800.0, 0.01751)), new(0.152d, new GammaParticle(162400.0, 0.00763)), new(0.01824d, new GammaParticle(520700.0, 0.00238)), new(0.050464d, new GammaParticle(562500.0, 0.0022)), new(0.033744d, new GammaParticle(581000.0, 0.00213)), new(0.01976d, new GammaParticle(670400.0, 0.00185)), new(0.02508d, new GammaParticle(794300.0, 0.00156)), new(0.031920000000000004d, new GammaParticle(891200.0, 0.00139)), new(0.022799999999999997d, new GammaParticle(895100.0, 0.00139)), new(0.116888d, new GammaParticle(932300.0, 0.00133)), new(0.022799999999999997d, new GammaParticle(956900.0, 0.0013)), new(0.0152d, new GammaParticle(961800.0, 0.00129)), new(0.011552d, new GammaParticle(1184400.0, 0.00105)), new(0.10400670649600001d, new GammaParticle(5870.0, 0.21122)), new(0.09542877863859596d, new GammaParticle(36848.0, 0.03365)), new(0.17379125594353664d, new GammaParticle(37362.0, 0.03318)), new(0.05337281831174817d, new GammaParticle(42380.0, 0.02926)), new(0.06708963261786743d, new GammaParticle(42810.0, 0.02896)), new(0.01371681430611928d, new GammaParticle(43335.0, 0.02861)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    